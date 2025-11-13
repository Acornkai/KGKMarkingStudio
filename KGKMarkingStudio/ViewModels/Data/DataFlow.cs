// using System;
// using KGKMarkingStudio.ViewModels.Containers;

// namespace KGKMarkingStudio.ViewModels.Data;

// public class DataFlow
// {
//     public void Bind(ProjectContainerViewModel? project)
//     {
//         if(project is null)
//             return;
//         foreach(var document in project.Documents)
//         {
//             Bind(document);
//         }
//     }

//     public void Bind(DocumentContainerViewModel? document)
//     {
//         if(document is null)
//             return;
        
//         foreach(var container in document.Pages)
//         {
//             var db = container.Properties;
//             var r = container.Record;

//             Bind(container.Template, db, r);
//             Bind(container, db, r);
//         }
//     }

// }
