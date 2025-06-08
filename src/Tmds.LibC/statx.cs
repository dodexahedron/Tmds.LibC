namespace Tmds.Linux;

public unsafe struct statx
{
  public        uint            stx_mask;
  public        uint            stx_blksize;
  public        ulong           stx_attributes;
  public        uint            stx_nlink;
  public        uint            stx_uid;
  public        uint            stx_gid;
  public        ushort          stx_mode;
  public        ulong           stx_ino;
  public        ulong           stx_size;
  public        ulong           stx_blocks;
  public        ulong           stx_attributes_mask;
  public        statx_timestamp stx_atime;
  public        statx_timestamp stx_btime;
  public        statx_timestamp stx_ctime;
  public        statx_timestamp stx_mtime;
  public        uint            stx_rdev_major;
  public        uint            stx_rdev_minor;
  public        uint            stx_dev_major;
  public        uint            stx_dev_minor;
  private fixed ushort          __spare0 [1];
  private fixed ulong           __spare2 [14];
  public const  uint            STATX__RESERVED   = 0x80000000;
  public const  uint            STATX_ALL         = 0xfff;
  public const  uint            STATX_ATIME       = 0x20;
  public const  uint            STATX_BASIC_STATS = 0x7ff;
  public const  uint            STATX_BLOCKS      = 0x400;
  public const  uint            STATX_BTIME       = 0x800;
  public const  uint            STATX_CTIME       = 0x80;
  public const  uint            STATX_GID         = 0x10;
  public const  uint            STATX_INO         = 0x100;
  public const  uint            STATX_MODE        = 0x2;
  public const  uint            STATX_MTIME       = 0x40;
  public const  uint            STATX_NLINK       = 0x4;
  public const  uint            STATX_SIZE        = 0x200;
  public const  uint            STATX_TYPE        = 0x1;
  public const  uint            STATX_UID         = 0x8;
  public const  int             UTIME_NOW         = 0x3fffffff;
  public const  int             UTIME_OMIT        = 0x3ffffffe;
}
