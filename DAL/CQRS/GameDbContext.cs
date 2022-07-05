using DAL.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CQRS
{
    public static class GameDbContext
    {
        static List<Game> games = new List<Game>()
        {
            new Game(){CreateTime = new DateTime(),Description="The Lord of the Rings: The Battle for Middle-earth II is a 2006 real-time strategy video game developed and published by Electronic Arts. The second part of the Middle-Earth strategy game, It is based on the fantasy novels The Lord of the Rings and The Hobbit by J. R. R. Tolkien and its live-action film series adaptation. It is the sequel to Electronic Arts' 2004 title The Lord of the Rings: The Battle for Middle-earth. Along with the standard edition, a Collector's Edition of the game was released, containing bonus material and a documentary about the game's development.",Id= Guid.NewGuid(), Name="The Lord of the Rings: The Battle for Middle-earth II",Price=65},
            new Game(){ Name="Apex Legends",Description ="Apex Legends is a free-to-play battle royale-hero shooter game developed by Respawn Entertainment and published by Electronic Arts. It was released for Microsoft Windows, PlayStation 4, and Xbox One in February 2019, for Nintendo Switch in March 2021, and for PlayStation 5 and Xbox Series X/S in March 2022. A mobile version of the game specially designed for touchscreens titled Apex Legends Mobile has also been announced which was released May 17, 2022 on Android and iOS. The game supports cross-platform play, excluding the mentioned mobile platforms.",CreateTime=new DateTime(),Id=Guid.NewGuid(), Price=0},
            new Game(){ Name ="Fallout",Description = "Fallout is a series of post-apocalyptic role-playing video games—and later action role-playing games—created by Interplay Entertainment. The series is set during the 21st, 22nd and 23rd centuries, and its atompunk retrofuturistic setting and art work are influenced by the post-war culture of 1950s United States, with its combination of hope for the promises of technology and the lurking fear of nuclear annihilation. A forerunner of Fallout is Wasteland, a 1988 game developed by Interplay Productions to which the series is regarded as a spiritual successor.",CreateTime = new DateTime(),Id=Guid.NewGuid(),Price=25}
        };
        public static List<Game> Games => games;
    }
}

