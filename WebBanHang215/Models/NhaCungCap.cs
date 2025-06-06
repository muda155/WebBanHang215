﻿using System;
using System.Collections.Generic;

namespace WebBanHang215.Models;

public partial class NhaCungCap
{
    public int MaNcc { get; set; }

    public string? TenNhaCungCap { get; set; }

    public string? DiaChi { get; set; }

    public string? SoDienThoai { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
