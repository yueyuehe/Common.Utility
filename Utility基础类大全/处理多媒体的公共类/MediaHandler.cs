using System;
using System.Media;

namespace Utilities
{
    /// <summary>
    /// 处理多媒体的公共类
    /// </summary>
    public class MediaHandler
    {
        #region 同步播放wav文件
        /// <summary>
        /// 以同步方式播放wav文件
        /// </summary>
        /// <param name="sp">SoundPlayer对象</param>
        /// <param name="wavFilePath">wav文件的路径</param>
        public static void SyncPlayWAV(SoundPlayer sp, string wavFilePath)
        {
            //设置wav文件的路径 
            sp.SoundLocation = wavFilePath;

            //使用异步方式加载wav文件
            sp.LoadAsync();

            //使用同步方式播放wav文件
            if (sp.IsLoadCompleted)
            {
                sp.PlaySync();
            }
        }

        /// <summary>
        /// 以同步方式播放wav文件
        /// </summary>
        /// <param name="wavFilePath">wav文件的路径</param>
        public static void SyncPlayWAV(string wavFilePath)
        {
            //创建一个SoundPlaryer类，并设置wav文件的路径
            SoundPlayer sp = new SoundPlayer(wavFilePath);

            //使用异步方式加载wav文件
            sp.LoadAsync();

            //使用同步方式播放wav文件
            if (sp.IsLoadCompleted)
            {
                sp.PlaySync();
            }
        }
        #endregion

        #region 异步播放wav文件
        /// <summary>
        /// 以异步方式播放wav文件
        /// </summary>
        /// <param name="sp">SoundPlayer对象</param>
        /// <param name="wavFilePath">wav文件的路径</param>
        public static void ASyncPlayWAV(SoundPlayer sp, string wavFilePath)
        {

            //设置wav文件的路径 
            sp.SoundLocation = wavFilePath;

            //使用异步方式加载wav文件
            sp.LoadAsync();

            //使用异步方式播放wav文件
            if (sp.IsLoadCompleted)
            {
                sp.Play();
            }
        }

        /// <summary>
        /// 以异步方式播放wav文件
        /// </summary>
        /// <param name="wavFilePath">wav文件的路径</param>
        public static void ASyncPlayWAV(string wavFilePath)
        {

            //创建一个SoundPlaryer类，并设置wav文件的路径
            SoundPlayer sp = new SoundPlayer(wavFilePath);

            //使用异步方式加载wav文件
            sp.LoadAsync();

            //使用异步方式播放wav文件
            if (sp.IsLoadCompleted)
            {
                sp.Play();
            }
        }
        #endregion

        #region 停止播放wav文件
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sp">SoundPlayer对象</param>
        public static void StopWAV(SoundPlayer sp)
        {
            sp.Stop();
        }
        #endregion
    }
}
