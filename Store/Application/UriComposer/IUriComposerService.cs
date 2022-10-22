﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogItems.UriComposer
{
    public interface IUriComposerService
    {
        string ComposeImageUri(string src);
    }

    public class UriComposerService : IUriComposerService
    {
        public string ComposeImageUri(string src)
        {
            if (!string.IsNullOrWhiteSpace(src))
            {
                return "https://localhost:44321/" + src.Replace("\\", "//");
            }
            else
            {
                return "";
            }
            
        }
    }
}
