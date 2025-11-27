namespace DinoGame.Exceptions
{
    public class ResourceNotFoundException(string message, Exception? e) : FileNotFoundException(message, e)
    {

    }
}