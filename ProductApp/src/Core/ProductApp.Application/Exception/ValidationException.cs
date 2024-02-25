namespace ProductApp.Application.Exception;

public class ValidationException : System.Exception
{
  public ValidationException() : this("Validation Error Occured!")
  {
    
  }

  public ValidationException(string Message) : base((Message))
  {
    
  }

  public ValidationException(System.Exception ex) : this(ex.Message)
  {
    
  }
}