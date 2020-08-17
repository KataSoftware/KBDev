using KS.Time.BR;
using KS.Time.BusinessObjects;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using SFS.Core.My;
using System;
using System.Collections.Generic;
using System.Text;

namespace KS.Time.Api
{
    public class SampleData
    {

        public void AddSampleData()
        {
           
            
            int totalProjects = 1000;
            KstProjectsBR brProjects = new KstProjectsBR(true);
            ContextRequest context = new ContextRequest();
            context.User = new SFS.Core.Security.BusinessObjects.secUser();
            context.Company = new SFS.Core.Security.BusinessObjects.secCompany();

            int numProjects = brProjects.GetCount(p=> true, context);
            if (numProjects < totalProjects)
            {
                int left = totalProjects - numProjects;
                for (int i = 0; i < left; i++)
                {
                    KstProject newProject = new KstProject();
                    newProject.GuidProject = SFS.Core.Utilities.UUID.NewSequential();
                    newProject.Name = SFS.Core.Utilities.Random.GetString(SFS.Core.Utilities.Random.GetInt32(50,180));
                    
                }
            }

        }
    }
}
