using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Configuration;

using System.IO;
using System.Reflection;

namespace WiseOn.VideoConversion
{

    public class FlvConversion
    {
        /// <summary>
        /// Converts a given file to its equivalent .flv, according to height enad width parameters
        /// </summary>
        /// <param name="sourceFile">Complete path to the physical source video file</param>
        /// <param name="destinationFile">Complete path to the destination .flv file</param>
        /// <param name="outputVideoWidth">Width of the resulting video</param>
        /// <param name="outputVideoHeight">Height of the resulting video</param>
        /// <returns></returns>
        public static Guid ConvertVideoToFlv(string sourceFile, string destinationFile, short outputVideoWidth, short outputVideoHeight)
        {
            //the ffmpeg library must be in the same directory as the running assembly
            string conversionEnginePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            conversionEnginePath = Path.Combine(conversionEnginePath, @"Libraries\ffmpeg\ffmpeg.exe");

            Guid returnValue =  Guid.NewGuid();
            Process ffmpegProcess = new Process();

            try 
	        {
                ffmpegProcess.StartInfo.Arguments = string.Format(" -i \"{0}\" -s {1}*{2} -deinterlace -ab 32 -r 15 -ar 22050 -ac 1 \"{3}\"", sourceFile, outputVideoWidth.ToString(), outputVideoHeight.ToString(), destinationFile);
                ffmpegProcess.StartInfo.FileName = conversionEnginePath;

                ffmpegProcess.Start();
                ffmpegProcess.PriorityClass = ProcessPriorityClass.BelowNormal;
                ffmpegProcess.WaitForExit();
                ffmpegProcess.Close();

                return returnValue;
	        }
	        catch (Exception)
	        {
		        throw;
	        }
            finally
            {
                ffmpegProcess.Close();
            }
        }
    }
}
