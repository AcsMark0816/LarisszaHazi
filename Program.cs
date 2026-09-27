namespace ize
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Players player1 = new Players("Daniel Kovacs", "Hungarian", 2001, "Budapest FC", 8, 12);
            Players player2 = new Players("Adam Nagy", "Hungarian", 2005, "Lake United", 3, 6);
            Console.WriteLine(player2);

            player1.MatchG(2);
            player2.MatchG(1);


            bool p1Trans = player1.TRaTO("Lake United");
            bool p2Trans = player2.TRaTO("Budapest FC");

            player1.AG();
            player2.AG();


            Movie movie1 = new Movie("Interstellar", "Christopher Nolan", "SciFi", 2014, 8.7, 2500000);
            // movie1.Title = "ize"; <- Ez akart lenni a kozvetlen?
            // nem lehet elerni oket
            movie1.UpR(9.0);

            Movie m = movie1 with { Title = "ize" };
            Movie mm = movie1 with { Director = "bize" };


        }
    }
}
