using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Syscon.IndirectCostAllocation
{
    public static class DataTableHelper
    {
        public static IList<ICAPDataModel> ToList(DataTable self)
        {
            IList<ICAPDataModel> data = new List<ICAPDataModel>();
            foreach (DataRow row in self.Rows)
            {
                var rv = new ICAPDataModel();
                var fields = typeof(ICAPDataModel).GetFields();

                var props = typeof(ICAPDataModel).GetProperties();

                foreach (DataColumn dc in self.Columns)
                {
                    var field = fields.Where(f => f.Name.ToUpper() == dc.ColumnName.ToUpper()).FirstOrDefault();
                    if (field == null)
                    {
                        var prop = props.Where(p => p.Name.ToUpper() == dc.ColumnName.ToUpper()).FirstOrDefault();
                        if (prop != null)
                        {
                            if (prop.PropertyType != typeof(string) && row[dc].ToString().Trim() == "")
                            {
                                // do nothing
                            }
                            else
                            {
                                prop.SetValue(rv, Convert.ChangeType(row[dc], prop.PropertyType), null);
                            }
                        }

                        continue;
                    }

                    if (field.FieldType != typeof(string) && row[dc].ToString().Trim() == "")
                    {
                        // do nothing
                    }
                    else
                    {
                        field.SetValue(rv, Convert.ChangeType(row[dc], field.FieldType));
                    }
                }

                data.Add(rv);
            }

            return data;
        }
    }
}
