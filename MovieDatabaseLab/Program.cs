
using MovieDatabaseLab;

List<Movie> movieList = new List<Movie>();

movieList.Add(new Movie("Star Wars", "Scifi"));

movieList.Add(new Movie("Miracle", "Drama"));

movieList.Add(new Movie("Finding Nemo", "Animated"));

movieList.Add(new Movie("Lion King", "Animated"));

movieList.Add(new Movie("Forrest Gump", "Drama"));

movieList.Add(new Movie("Casino", "Drama"));

movieList.Add(new Movie("Saving Private Ryan", "Drama"));

movieList.Add(new Movie("The Ring", "Horror"));

movieList.Add(new Movie("Back to the Future", "Scifi"));

movieList.Add(new Movie("Halloween", "Horror"));



int numberOfMovies = movieList.Count;



Console.WriteLine("Welcome to the Movie List Application!");

Console.WriteLine("");

Console.WriteLine($"There are {numberOfMovies} movies in this list.");

Console.WriteLine("");



bool continueLoop = false;

do

{

    Console.WriteLine("What Category are you interested in?\n 1. Animated \n 2. Drama \n 3. Horror \n 4. Scifi \n 5. Exit Application");

    Console.WriteLine("");

    string userInput = Console.ReadLine();

    int option = int.Parse(userInput);



    switch (option)

    {

        case 1:

            Console.WriteLine("");

            Console.WriteLine("Animated Movies:");

            List<Movie> animated = movieList.Where(x => x.Category == "Animated").ToList();

            foreach (var movie in animated)

            {

                Console.WriteLine(movie.Title);

            }

            break;

        case 2:

            Console.WriteLine("");

            Console.WriteLine("Drama Movies:");

            List<Movie> drama = movieList.Where(x => x.Category == "Drama").ToList();

            foreach (var movie in drama)

            {

                Console.WriteLine(movie.Title);

            }

            break;

        case 3:

            Console.WriteLine("");

            Console.WriteLine("Horror Movies:");

            List<Movie> horror = movieList.Where(x => x.Category == "Horror").ToList();

            foreach (var movie in horror)

            {

                Console.WriteLine(movie.Title);

            }

            break;

        case 4:

            Console.WriteLine("");

            Console.WriteLine("Scifi Movies:");

            List<Movie> scifi = movieList.Where(x => x.Category == "Scifi").ToList();

            foreach (var movie in scifi)

            {

                Console.WriteLine(movie.Title);

            }

            break;

        case 5:

            Console.WriteLine("exiting program...");

            Environment.Exit(0);

            break;

        default:

            Console.WriteLine("");

            Console.WriteLine("Invalid Option");

            break;

    }

    Console.WriteLine("");

    Console.WriteLine("Would you like to continue? (y/n): ");

    string input = Console.ReadLine();

    continueLoop = input.ToLower() == "y";

} while (continueLoop);



Console.WriteLine("Okay. Goodbye.");

Environment.Exit(0);



Console.ReadKey();