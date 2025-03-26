using System;

public class SayTubeVideo

    private int id;
    private string title;       
    private interface playCount;
{

   public SayTubeVideo(string judulVideo)
    {
    if(judulVideo == null)
    {
        throw new ArgumentNullException("judulVideo", "Judul Video Tidak Boleh Null");
    }
    if(judulVideo.Length > 200)
    {
        throw new ArgumentException("Judul video tidak boleh lebih dari 200");
    }
    Random rand = new Random();
    this.id = rand.Next(100000, 99999);
    this.judulVideo = judulVideo;
    this.playCount = 0;

    }
    public void increasePlayCount(int count)
    {
    if (count > 25000000)
    {
        throw new ArgumentOutOfRangeException("count","Penambahan playCount maksimal 25.000.000 per panggilan")
    }
    try
    {
        checked
        {
            this.playCount += count;
        }
    }
    catch (OverflowException)
    {
        Console.WriteLine("Error: Terjadi overflow pada playCount.");
    }

}
    this.playCount += count;
    public void PrintVideoDetails()
    {
            Console.WriteLine($"ID:{this.id}");
            Console.WriteLine($"judulVideo:{this.judulVideo}");
            Console.WriteLine($"PlayCount:{this.playCount}");
            
}

}   
