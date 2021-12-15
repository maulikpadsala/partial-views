using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Files.Core.PartailViews.Models;

namespace Files.Core.PartailViews.Repository
{
    public class Filmmaking : IFilms
    {
        public List<Films> ListofFilms()
        {
            var listoffilms = new List<Films>()
            {
                new Films()
                {
                    ID = 1,
                    Title = "American Pie",
                    Duration = "2:30",
                    Discritption = "American Pie is a film series consisting of four sex comedy films. American Pie, the first film in the series, was released by Universal Pictures in 1999. The film became a worldwide pop culture phenomenon and gained a cult following among young people. Following American Pie, the second and third films in the series American Pie 2 (2001) and American Wedding (2003) were released; the fourth, American Reunion, was released in 2012. A spin-off film series entitled American Pie Presents consists of five direct-to-video films that were released from 2005 to 2020."
                },
                 new Films()
                {
                    ID = 2,
                    Title = "The girl next door",
                    Duration = "2:45",
                    Discritption = "Ambitious high school senior Matthew Kidman has been accepted to Georgetown University, but cannot afford the tuition. He has raised $25,000 in order to bring a brilliant Cambodian student, Samnang, to study in the United States, but finds little else truly memorable about his high school experience. "
                },
                  new Films()
                {
                      ID = 3,
                    Title = "Fast and Furious",
                    Duration = "2:45",
                    Discritption = "Fast & Furious (also known as The Fast and the Furious) is a media franchise centered on a series of action films that are largely concerned with illegal street racing, heists, spies and family. The franchise also includes short films, a television series, live shows, video games and theme park attractions. It is distributed by Universal Pictures."
                },
                   new Films()
                {
                       ID = 4,
                    Title = "The Avengers",
                    Duration = "2:30",
                    Discritption = "The Avengers premiered in Los Angeles on April 11, 2012, and was released in the United States on May 4, as the last film of Phase One of the MCU. "
                },
                    new Films()
                {
                        ID = 5,
                    Title = "pirates of the caribbean",
                    Duration = "2:45",
                    Discritption = "Pirates of the Caribbean is a series of fantasy swashbuckler films produced by Jerry Bruckheimer and based on Walt Disney's theme park attraction of the same name. The film series serves as a major component of the eponymous media franchise."
                },
            };
            return listoffilms;
        }


    }
}
