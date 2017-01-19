using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaysSandwitch.Core.Models;

namespace RaysSandwitch.Core.Repository
{
    public class RaysSandwitchRepo
    {
        private static List<SandwitchGroup> sandwitchGroups = new List<SandwitchGroup>()
        {
            new SandwitchGroup()
            {
                 GroupId = 1, ImagePath ="", Title="Ghaas Foos",
                 Sandwitches = new List<Sandwitch>()
                 {
                     new Sandwitch()
                     {
                         Id = 1, SandwitchName = "Plain Sandwitch", IsFavorite = false,NumberOfBreads = 2,Price = 20.00
                     },
                     new Sandwitch()
                     {
                          Id = 2,SandwitchName = "Veg. Sandwitch", IsFavorite = false,NumberOfBreads = 4,Price = 35.00
                     },
                     new Sandwitch()
                     {
                          Id = 3,SandwitchName = "Veg. Club Sandwitch", IsFavorite = true ,NumberOfBreads = 6,Price = 55.99
                     },
                     new Sandwitch()
                     {
                          Id = 4,SandwitchName = "Cheeze Club Sandwitch", IsFavorite = true,NumberOfBreads = 8,Price = 99.99
                     }
                 }


            },
            new SandwitchGroup()
            {
                GroupId = 2, ImagePath = "", Title = "Chicken Lovers", Sandwitches = new List<Sandwitch>()
                {
                   new Sandwitch()
                     {
                         Id = 5, SandwitchName = "Chicken Sandwitch", IsFavorite = false,NumberOfBreads = 2,Price = 45.00
                     },
                     new Sandwitch()
                     {
                          Id = 6,SandwitchName = "Chicken Tikka Sandwitch", IsFavorite = true,NumberOfBreads = 4,Price = 65.00
                     },
                     new Sandwitch()
                     {
                          Id = 7,SandwitchName = "Chicken Club Sandwitch", IsFavorite = true ,NumberOfBreads = 6,Price = 85.99
                     },
                     new Sandwitch()
                     {
                          Id = 8,SandwitchName = "Chicken Cheeze Club Sandwitch", IsFavorite = true,NumberOfBreads = 8,Price = 105.99
                     }
                }
            }
        };

        /// <summary>
        /// This method is used to return all the available Sandwitches.
        /// </summary>
        /// <returns>List instance of the class Sandwitch.</returns>
        public List<Sandwitch> getAllSandwitches()
        {
            IEnumerable<Sandwitch> returnList = from sandwitchgroup in sandwitchGroups
                                                from Sand in sandwitchgroup.Sandwitches
                                                select Sand;
            return returnList.ToList<Sandwitch>();
        }

        /// <summary>
        /// This method is used to return single sandwitch based on its associated Id.
        /// </summary>
        /// <param name="id"> Int Id is unique identifier of Sandwitch.</param>
        /// <returns>Instance of Class Sandwitch with single record.</returns>
        public Sandwitch getSandwitchById(int id)
        {
            var returnSand = from mysandwitchGroup in sandwitchGroups
                             from allSandwitch in mysandwitchGroup.Sandwitches
                             where allSandwitch.Id == id
                             select allSandwitch;
            return returnSand.FirstOrDefault();
        }

        public List<SandwitchGroup> getAllSandwitchGroups()
        {
            return sandwitchGroups;
        }

        public List<Sandwitch> getSandwitchesByGroup(int groupId)
        {
            var SandwithchGroup = sandwitchGroups.Where(t => t.GroupId == groupId).FirstOrDefault();
            return SandwithchGroup.Sandwitches.ToList<Sandwitch>();
        }

        public List<Sandwitch> getFavoriteSandwitches()
        {
            IEnumerable<Sandwitch> returnFavSands = from mygrouplist in sandwitchGroups
                                                    from mySandwitches in mygrouplist.Sandwitches
                                                    where mySandwitches.IsFavorite
                                                    select mySandwitches;
            return returnFavSands.ToList<Sandwitch>();
        }
    }
}
