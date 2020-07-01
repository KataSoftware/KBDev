using KS.Time.BusinessObjects;
using SFS.Core.My;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KS.Time.BR
{
   public class CustomRulesbBR
    {
        public void SampleCreate(ContextRequest contextRequest)
        {
            KstProject project = new KstProject();
            project.Name = "Proyecto X";
            
            project = BR.KstProjectsBR.Instance.Create(project, contextRequest);

            KstActivity activity = new KstActivity();
            activity.Name = "Actividad 1";
            activity.KstProject = project;
            activity = BR.KstActivitiesBR.Instance.Create(activity, contextRequest);

            activity = new KstActivity();
            activity.Name = "Actividad 2";
            activity.GuidProject = project.GuidProject;
            activity = BR.KstActivitiesBR.Instance.Create(activity, contextRequest);

            List<KstActivity> activities = new List<KstActivity>();
            for (int i = 0; i < 10000; i++)
            {
                activities.Add(new KstActivity() 
                { 
                    GuidProject = project.GuidProject, 
                    Name= "test " + i.ToString() 
                });
            }
            BR.KstActivitiesBR.Instance.Create(activities, contextRequest);
        }

        public void SampleUpdate(ContextRequest contextRequest)
        {
            Guid guidProject = Guid.Parse("C9930D58-DA0B-4379-A76C-78C7E68F199");
            KstProject project = new KstProject();
            project.Name = "Proyecto X";
            project.GuidProject = guidProject;
            project = BR.KstProjectsBR.Instance.Create(project, contextRequest);

            // Actualización rápida sin ir a la base de datos
            var projectForUpdate = new KstProject();
            projectForUpdate.GuidProject = guidProject;
            projectForUpdate.Name = "Proyecto Z";
            BR.KstProjectsBR.Instance.UpdateAgile(projectForUpdate, contextRequest, KstProject.PropertyNames.Name);
            
            // Actualización de todos los campos 
            projectForUpdate = BR.KstProjectsBR.Instance.GetBy(p=> p.GuidProject == guidProject).FirstOrDefault();
            projectForUpdate.Name = "Proyecto Y";
            BR.KstProjectsBR.Instance.Update(projectForUpdate, contextRequest);

            // Actualización de todos los campos en un proceso masivo 
            var allProjects = BR.KstProjectsBR.Instance.GetBy(p => true);
            foreach (var itemProject in allProjects)
            {
                itemProject.Name = "test";
            }
            BR.KstProjectsBR.Instance.UpdateBulk(allProjects, contextRequest);
        }

        public void SampleDelete(ContextRequest contextRequest)
        {
            Guid guidProject = Guid.Parse("C9930D58-DA0B-4379-A76C-78C7E68F199");
            var project = BR.KstProjectsBR.Instance.GetBy(p=> p.GuidProject == guidProject).FirstOrDefault();
            
            BR.KstProjectsBR.Instance.Delete(project, contextRequest);

            var activities = BR.KstActivitiesBR.Instance.GetBy(p=> true);

            BR.KstActivitiesBR.Instance.DeleteBulk(activities, contextRequest);

        }

        public void SampleGet(ContextRequest contextRequest)
        {

            var activities = BR.KstActivitiesBR.Instance.GetBy(
                p=> p.KstProject.Name.Contains("abc") && p.KstProject.KstProjectUsers.Count() == 0
                , contextRequest);

            activities = BR.KstActivitiesBR.Instance.GetBy(
                "it.KstProject.Name.Contains(\"abc\") AND it.KstProject.KstProjectUsers.Count() = 0"
                , contextRequest);

            DateTime date = new DateTime(2020, 12, 12);
            
            activities = BR.KstActivitiesBR.Instance.GetBy(p=> p.KstProject.CreatedDate > date,
                contextRequest);

            activities = BR.KstActivitiesBR.Instance.GetBy(
                $"it.KstProject.CreatedDate > DateTime({date.Year},{date.Month},{date.Day})",
                contextRequest);
            
            contextRequest.CustomQuery.Page = 1;
            contextRequest.CustomQuery.PageSize = 10;
            contextRequest.CustomQuery.SortDirection = SFS.Core.Data.SortDirection.Descending;
            contextRequest.CustomQuery.OrderBy = KstActivity.PropertyNames.Name;
            activities = BR.KstActivitiesBR.Instance.GetBy(
               $"it.KstProject.CreatedDate > DateTime({date.Year},{date.Month},{date.Day})",
               contextRequest);





        }


    }
}
