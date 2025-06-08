namespace Tmds.Linux;

[PublicAPI]
public struct aio_context_t
{
  public unsafe aio_ring* ring;
}
