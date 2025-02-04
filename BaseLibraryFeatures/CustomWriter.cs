using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibraryFeatures
{
    /// <summary>
    /// CustomWriter class to inherit BaseLibraryFeatures
    /// </summary>
    public class CustomWriter : StreamWriter
    {
        public int lineNumber { get; set; } = 1;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFIlter"/> class with the specified file path.
        /// </summary>
        /// <param name="path">The file path where the stream writer writes data.</param>
        public CustomWriter(string path) : base(path) { }

        /// <summary>
        /// Writes a line of text to the stream with custom formatting.
        /// </summary>
        /// <param name="value">The text to write to the stream.</param>
        public override void WriteLine(string value)
        {
            // Custom behavior for writing a line of text.
            Console.WriteLine($"\n writing {lineNumber}th line");
            lineNumber++;
            base.WriteLine($"[Custom]: {value}");
        }
    }
}
