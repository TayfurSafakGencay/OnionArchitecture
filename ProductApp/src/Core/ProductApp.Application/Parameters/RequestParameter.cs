namespace ProductApp.Application.Parameters;

public class RequestParameter(int pageSize, int pageNumber)
{
  public int PageSize { get; set; } = pageSize;

  public int PageNumber { get; set; } = pageNumber;
}