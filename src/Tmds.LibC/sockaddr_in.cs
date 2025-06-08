namespace Tmds.Linux;

public unsafe struct sockaddr_in
{
  public        in_addr     sin_addr;
  private fixed byte        __sin_zero [8];
  public        sa_family_t sin_family { get; set; }
  public        UInt16   sin_port   { get; set; }
}