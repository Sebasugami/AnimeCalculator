using System;

namespace Calculadora_anime
{
    class Program
    {
        //Este programa calculará el tiempo que se tarda en ver un anime a basándose en el número de episodios del mismo
        static void Main(string[] args)
        {
            //Se dice el número de episodios y se calculan los minutos totales del anime
            int Episodes = NumberOfEpisodes();
            int MinsPerEpisodes = Episodes * 25;
            //Se calcula si el anime tiene horas o no y la duración del mismo
            if (MinsPerEpisodes == 60 || MinsPerEpisodes > 60)
            {
                int HoursOfTheAnime = HoursOfAllTheEpisodesOfTheAnime(MinsPerEpisodes);
                MinsPerEpisodes = MinsPerEpisodes % (60 * HoursOfTheAnime);

                Console.WriteLine($"The anime's duration is {HoursOfTheAnime} hours and {MinsPerEpisodes} minutes");
                Console.ReadLine();
            }
            else
            {

                Console.WriteLine($"The anime's duration is {MinsPerEpisodes} minutes");
                Console.ReadLine();
            }
        }
        static int NumberOfEpisodes() //Se introduce y comprueba el número de episodios
        {
            //Se introduce y comprueba el número de episodios
            Console.WriteLine("Please, enter the number of episodes of the anime");
            int Episodes;

            do
            {
                try
                {
                    Episodes = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Exceptions();
                    Episodes = 0;
                }
                catch (OverflowException)
                {
                    Exceptions();
                    Episodes = 0;
                }

            } while (Episodes == 0);

            return Episodes;
        }

        static void Exceptions()
        {
            ConsoleClear();
            Console.WriteLine("Please, insert a valid value");
            Console.ReadLine();
        }

        static int HoursOfAllTheEpisodesOfTheAnime(int MinutesOfAllTheAnime) //Calcula el número de horas que tenga el anime
        {
            int HoursOfTheAnime = MinutesOfAllTheAnime / 60;

            return HoursOfTheAnime;
        }
        static void ConsoleClear()
        {
            Console.Clear();
        }
    }
}

