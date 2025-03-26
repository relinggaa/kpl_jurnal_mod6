using System;

public class SayTubeUser

    private int id;
	private uploadedVideos: list<SayTubeVideo>[8];

    private string username;
{
	public SayTubeUser(string username)
	{
		Random rand=new Random();
		this.id=rand.Next(100000,99999);
		this.judulVideo=judulVideo;
		this.username = username;
		this.uploadedVideos:list < SayTubeVideo >= 0;
		
	}
	public void GetTotalVideoPlayCount()
	{
		SayTubeVideo video=new SayTubeVideo();
		video.increasePlayCount();
		


    }
	public void addVideo()
	{
		for (int i = 0; i < uploadedVideo.length; i++)
	{
			uploadedVideo.addVideo(i);
	}
	}
	
}
