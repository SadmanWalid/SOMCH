using System;
using System.Collections.Generic;

namespace SOMCH.Models
{
    public partial class FileInfo
    {
        public string Id { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool Enabled { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? Filenamewithextension { get; set; }
        public string? Filerelativepath { get; set; }
        public string? Filerootpath { get; set; }
        public string? Filetypeenumkey { get; set; }
        public string? Filecategoryenumkey { get; set; }
    }
}
