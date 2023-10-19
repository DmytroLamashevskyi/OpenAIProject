using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webapi.Models.Request
{
    /// <summary>
    /// Creates an image given a prompt.
    /// </summary>
    public class ImageGenRequest
    {
        /// <summary>
        /// A text description of the desired image(s). The maximum length is 1000 characters.
        /// </summary>
        [Required]
        public string? Prompt { get; set; }
        /// <summary>
        /// The number of images to generate. Must be between 1 and 10.
        /// </summary>
        public short? N { get; set; }
        /// <summary>
        /// The size of the generated images. Must be one of 256x256, 512x512, or 1024x1024
        /// </summary>
        public string? Size { get; set; } 
        
    }
}
