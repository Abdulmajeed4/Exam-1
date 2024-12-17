public class Movie{
    public string Title {get; set;}
    public string Director {get; set;}
    public double Duration {get; set;}

    public void PrintDetails(){
        Console.WriteLine($"Title: {Title}, Director: {Director}, Duration: {Duration} minutes");
    }
}