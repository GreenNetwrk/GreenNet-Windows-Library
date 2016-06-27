using System;
using System.Net;
using System.IO;

public class greennetHost
{
    private string httpGET(string sURL)
    {
        WebRequest request = WebRequest.Create(sURL);

        WebResponse response = request.GetResponse();

        Stream dataStream = response.GetResponseStream();

        StreamReader reader = new StreamReader(dataStream);

        string responseFromServer = reader.ReadToEnd();

        return responseFromServer;
    }
	public string pullRequests()
	{
        
	}
}
