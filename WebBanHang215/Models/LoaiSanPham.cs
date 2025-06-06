﻿using System;
using System.Collections.Generic;

namespace WebBanHang215.Models;

public partial class LoaiSanPham
{
    public int MaLoai { get; set; }

    public string TenLoai { get; set; } = null!;

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
