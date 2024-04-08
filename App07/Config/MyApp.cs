namespace app07.Config;


public class MyApp
{
    private int port;
    private string ip;
    private string username;
    private string password;

    public MyApp Port(int port)
    {
        this.port = port;
        return this;
    }
    public MyApp Ip(string ip)
    {
        this.ip = ip;
        return this;
    }
    public MyApp Username(string username)
    {
        this.username = username;
        return this;
    }
    public MyApp Password(string password)
    {
        this.password = password;
        return this;
    }
}



public class MyAppTest
{
    public MyAppTest()
    {
        var app = new MyApp();
        app.Ip("loalhost");
        app.Port(1);
        app.Username("username");
        app.Password("password");


        //FluentApi
        app.Ip("loalhost")
            .Port(1)
            .Username("username")
            .Password("password")
           ;
    }
}