using Film_Library.React.Models;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Library.React.Data
{
    public class FilmLibraryContextInitial
    {
        public static List<FilmGenre> FilmGenreInitial()
        {
            return new List<FilmGenre>
            {
                new FilmGenre{ Id = 1, Id_Film = 1, Id_Genre = 1},
                new FilmGenre{ Id = 2, Id_Film = 1, Id_Genre = 2},
                new FilmGenre{ Id = 3, Id_Film = 1, Id_Genre = 3},
                new FilmGenre{ Id = 4, Id_Film = 2, Id_Genre = 1},
                new FilmGenre{ Id = 5, Id_Film = 2, Id_Genre = 2},
                new FilmGenre{ Id = 6, Id_Film = 2, Id_Genre = 3},
                new FilmGenre{ Id = 7, Id_Film = 3, Id_Genre = 1},
                new FilmGenre{ Id = 8, Id_Film = 3, Id_Genre = 2},
                new FilmGenre{ Id = 9, Id_Film = 3, Id_Genre = 3},
                new FilmGenre{ Id = 10, Id_Film = 4, Id_Genre = 1},
                new FilmGenre{ Id = 11, Id_Film = 4, Id_Genre = 2},
                new FilmGenre{ Id = 12, Id_Film = 5, Id_Genre = 4},
            };
        }
        public static List<Genre> GenreInitial()
        {
            return new List<Genre>
            {
                new Genre
                {
                    Id=1,
                    Name = "Фантастика",
                },
                new Genre
                {
                    Id=2,
                    Name = "Приключения",
                },
                new Genre
                {
                    Id=3,
                    Name = "Cемейный",
                },
                new Genre
                {
                    Id=4,
                    Name = "Комедия",
                }
            };
        }
        public static List<FilmActor> FilmActorInitial()
        {
            return new List<FilmActor>
            {
               new FilmActor
               {
                   Id = 1,
                   Id_Film = 1,
                   Id_Actor = 1,

               },
               new FilmActor
               {
                   Id = 2,
                   Id_Film = 1,
                   Id_Actor = 2,

               },
               new FilmActor
               {
                   Id = 3,
                   Id_Film = 1,
                   Id_Actor = 3,
               },
               new FilmActor
               {
                   Id = 4,
                   Id_Film = 2,
                   Id_Actor = 3,
               },
               new FilmActor
               {
                   Id = 5,
                   Id_Film = 2,
                   Id_Actor = 5,
               },
               new FilmActor
               {
                   Id = 6,
                   Id_Film = 3,
                   Id_Actor = 1,
               },
               new FilmActor
               {
                   Id = 7,
                   Id_Film = 3,
                   Id_Actor = 2,
               },
               new FilmActor
               {
                   Id = 8,
                   Id_Film = 3,
                   Id_Actor = 3,
               },
               new FilmActor
               {
                   Id = 9,
                   Id_Film = 3,
                   Id_Actor = 4,
               },
               new FilmActor
               {
                   Id = 10,
                   Id_Film = 3,
                   Id_Actor = 5,
               },
                new FilmActor
               {
                   Id = 11,
                   Id_Film = 4,
                   Id_Actor = 6,
               },
                new FilmActor
               {
                   Id = 12,
                   Id_Film = 5,
                   Id_Actor = 7,
               },
                new FilmActor
               {
                   Id = 13,
                   Id_Film = 5,
                   Id_Actor = 8,
               },
            };
        }
        public static List<Actor> ActorInitial()
        {
            List<FilmActor> fa = FilmActorInitial();
            return new List<Actor>()
            {
                new Actor
                {
                    Id = 1,
                    Name = "Дэниел",
                    Surname = "Рэдклифф",
                    DateBirth = "23 июля 1989 г",
                    PlaceBirth = "Хаммерсмит",
                    Path_Img = "/img/Actors/DanielRadcleffe.jpg",

                },
                new Actor
                {
                    Id = 2,
                    Name = "Руперт",
                    Surname = "Гринт",
                    DateBirth = "24 августа 1988 г",
                    PlaceBirth = " Харлоу, Эссекс, Англия, Великобритания",
                    Path_Img = "/img/Actors/RupertGrint.jpg",
                },
                new Actor
                {
                    Id = 3,
                    Name = "Эмма",
                    Surname = "Уотсон",
                    DateBirth = "15 апреля 1990 г",
                    PlaceBirth = "Оксфорд, Великобритания",
                    Path_Img = "/img/Actors/EmmaUotson.jpg",
                },
                new Actor
                {
                    Id = 4,
                    Name = "Том",
                    Surname = "Фелтон",
                    DateBirth = "22 сентября 1987 г",
                    PlaceBirth = " Кенсингтон, Лондон, Великобритания",
                    Path_Img = "/img/Actors/TomFelton.jpg",
                },
                new Actor
                {
                    Id = 5,
                    Name = "Мэгги",
                    Surname = "Смит",
                    DateBirth = "28 декабря 1934 г",
                    PlaceBirth = "Илфорд, Эссекс, Англия, Великобритания",
                    Path_Img = "/img/Actors/MaggieSmith.jpg",
                },
                 new Actor
                {
                    Id = 6,
                    Name = "Мэтт",
                    Surname = "Дэймон",
                    DateBirth = "8 октября 1970 г",
                    PlaceBirth = "Кембридж, Массачусетс, США",
                    Path_Img = "/img/Actors/MettDeymon.jpg",
                },
                 new Actor
                {
                    Id = 7,
                    Name = "Вуди",
                    Surname = "Харрельсон",
                    DateBirth = "23 июля 1961 г",
                    PlaceBirth = "Мидленд, Техас, США",
                    Path_Img = "/img/Actors/VudiKharrelson.jpg",
                },
                 new Actor
                {
                    Id = 8,
                    Name = "Билл",
                    Surname = "Мюррей",
                    DateBirth = "21 сентября 1950 г",
                    PlaceBirth = "Уилметт, Иллинойс, США",
                    Path_Img = "/img/Actors/BillMurray.jpg",
                },
            };
        }

        public static List<Film> FilmInitial()
        {
            List<FilmActor> fa = FilmActorInitial();
            return new List<Film>()
            {
                new Film{
                    Id = 1,
                    Name ="Гарри Поттер и философский камень",
                    ShortDescription = "Гарри поступает в школу магии Хогвартс и заводит друзей. Первая часть большой франшизы о маленьком волшебнике",
                    FullDescription ="Жизнь десятилетнего Гарри Поттера нельзя назвать сладкой: родители умерли, едва ему исполнился год, а от дяди и тёти, взявших сироту на воспитание, достаются лишь тычки да подзатыльники. Но в одиннадцатый день рождения Гарри всё меняется. Странный гость, неожиданно появившийся на пороге, приносит письмо, из которого мальчик узнаёт, что на самом деле он - волшебник и зачислен в школу магии под названием Хогвартс. А уже через пару недель Гарри будет мчаться в поезде Хогвартс-экспресс навстречу новой жизни, где его ждут невероятные приключения, верные друзья и самое главное — ключ к разгадке тайны смерти его родителей.",
                    Countries = "Великобритания, США",
                    Producer = "Крис Коламбус",
                    YearProduction = "2001",
                    PathImg = "/img/Films/GarriPotter1.jpg",
                },
                new Film{
                    Id = 2,
                    Name ="Гарри Поттер и Тайная комната",
                    ShortDescription = "Домашний эльф, магический дневник и привидение. Второй год Гарри в школе Хогвартс — еще более захватывающий",
                    FullDescription ="Гарри Поттер переходит на второй курс Школы чародейства и волшебства Хогвартс. Эльф Добби предупреждает Гарри об опасности, которая поджидает его там, и просит больше не возвращаться в школу.Юный волшебник не следует совету эльфа и становится свидетелем таинственных событий, разворачивающихся в Хогвартсе. Вскоре Гарри и его друзья узнают о существовании Тайной Комнаты и сталкиваются с новыми приключениями, пытаясь победить темные силы.",
                    Countries = "Великобритания, США",
                    Producer = "Крис Коламбус",
                    YearProduction = "2002",
                    PathImg = "/img/Films/GarriPotter2.jpg",
                },
                new Film{
                    Id = 3,
                    Name ="Гарри Поттер и узник Азкабана",
                    ShortDescription = "Беглый маг, тайны прошлого и путешествия во времени. В третьей части поттерианы Альфонсо Куарон сгущает краски",
                    FullDescription ="В третьей части истории о юном волшебнике полюбившиеся всем герои — Гарри Поттер, Рон и Гермиона — возвращаются уже на третий курс школы чародейства и волшебства Хогвартс. На этот раз они должны раскрыть тайну узника, сбежавшего из зловещей тюрьмы Азкабан, чье пребывание на воле создает для Гарри смертельную опасность...",
                    Countries = "Великобритания, США",
                    Producer = "Альфонсо Куарон",
                    YearProduction = "2004",
                    PathImg = "/img/Films/GarriPotter3.jpg",
                },
                new Film{
                    Id = 4,
                    Name ="Марсианин",
                    ShortDescription = "Инженер-биолог пытается выжить на Марсе, ожидая помощи с Земли. Научно-фантастический блокбастер Ридли Скотта",
                    FullDescription ="Марсианская миссия «Арес-3» в процессе работы была вынуждена экстренно покинуть планету из-за надвигающейся песчаной бури. Инженер и биолог Марк Уотни получил повреждение скафандра во время песчаной бури. Сотрудники миссии, посчитав его погибшим, эвакуировались с планеты, оставив Марка одного. Очнувшись, Уотни обнаруживает, что связь с Землёй отсутствует, но при этом полностью функционирует жилой модуль. Главный герой начинает искать способ продержаться на имеющихся запасах еды, витаминов, воды и воздуха ещё 4 года до прилёта следующей миссии «Арес-4».",
                    Countries = "США, Великобритания, Венгрия, Иордания",
                    Producer = "Ридли Скотт",
                    YearProduction = "2015",
                    PathImg = "/img/Films/Martian.jpg",
                },
                new Film{
                    Id = 5,
                    Name ="Добро пожаловать в Zомбилэнд",
                    ShortDescription = "Только зомби-апокалипсис может заставить социофоба найти друзей. Комедия с уморительным камео Билла Мюррея",
                    FullDescription ="После нашествия зомби в США небольшая группа выживших скитается по стране от побережья к побережью, сражаясь с живыми мертвецами. Они решают остановиться в парке развлечений, надеясь, что там будут в безопасности.",
                    Countries = "США",
                    Producer = "Рубен Флейшер",
                    YearProduction = "2009",
                    PathImg = "/img/Films/Zombieland.jpg",
                },
            };
        }
    }

}
