using RtfPipe.Model;

namespace RtfPipe;

public class ExternalPicture: Node
{
  public string Uri { get; }

  public ExternalPicture(string uri)
  {
    Uri = uri;
  }

  internal override void Visit(INodeVisitor visitor)
  {
    visitor.Visit(this);
  }
}
