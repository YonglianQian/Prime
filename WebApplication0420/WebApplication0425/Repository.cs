using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication0425
{
    public class Repository
    {
        private DataStoreEntities2 entities = new DataStoreEntities2();
        public IEnumerable<Detail> Details
        {
            get { return entities.Details; }
        }
        public void SaveDetail(Detail detail)
        {
            if (detail.Id==0)
            {
                entities.Details.Add(detail);
            }
            else
            {
                Detail dbEntry = entities.Details.Find(detail.Id);
                if (dbEntry!=null)
                {
                    dbEntry.Data = detail.Data;
                    dbEntry.Name = detail.Name;
                }
            }
            entities.SaveChanges();
        }
    }
}