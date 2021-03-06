﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;

namespace ImageProcessing.Filter
{
    class MorphologicalFilter: IFilter
    {
        public const int EROSION = 1;
        public const int DILATION = 2;
        public const int OPEN = 3;
        public const int CLOSE = 4;

        private const int BYTE_IN_PIXEL_COUNT = 4;
        private const int BRIGHT_COLOR = 255;
        private const int DARK_COLOR = 0;

        public Bitmap ApplyFilter(Bitmap srcImage, int filterSubType, int level)
        {
            Bitmap resBitmap = null;
            if (srcImage == null)
            {
                return resBitmap;
            }
            switch (filterSubType)
            {
                case EROSION:
                    resBitmap = Erode(srcImage, level);
                    break;
                case DILATION:
                    resBitmap = Dilate(srcImage, level);
                    break;
                case OPEN:
                    srcImage = Erode(srcImage, level);
                    resBitmap = Dilate(srcImage, level);
                    break;
                case CLOSE:
                    srcImage = Dilate(srcImage, level);
                    resBitmap = Erode(srcImage, level);
                    break;
            }
            return resBitmap;
        }

        private Bitmap Dilate(Bitmap srcImage, int level)
        {
            BitmapData srcBitmapData = srcImage.LockBits(new Rectangle(0, 0, srcImage.Width, srcImage.Height),
               ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] originalPixelBuffer = new byte[srcBitmapData.Stride * srcBitmapData.Height];
            byte[] resultPixelBuffer = new byte[srcBitmapData.Stride * srcBitmapData.Height];

            Marshal.Copy(srcBitmapData.Scan0, originalPixelBuffer, 0, originalPixelBuffer.Length);
            srcImage.UnlockBits(srcBitmapData);

            int kernelSize = level;
            int kernelBoundOffset = 0;
            int anchorByteOffset = 0;
            byte blueByte = DARK_COLOR;
            byte greenByte = DARK_COLOR;
            byte redByte = DARK_COLOR;
            byte defaultColorValue = DARK_COLOR;

            //выбираем точку-центр элемента
            for (int y = kernelSize; y < srcImage.Height - kernelSize; y++)
            {
                for (int x = kernelSize; x < srcImage.Width - kernelSize; x++)
                {
                    //номер байта ~ сдвигу по y и x
                    anchorByteOffset = y * srcBitmapData.Stride + x * BYTE_IN_PIXEL_COUNT;

                    blueByte = defaultColorValue;
                    greenByte = defaultColorValue;
                    redByte = defaultColorValue;

                    for (int kernelY = -kernelSize; kernelY <= kernelSize; kernelY++)
                    {
                        for (int kernelX = -kernelSize; kernelX <= kernelSize; kernelX++)
                        {
                            kernelBoundOffset = anchorByteOffset + (kernelX * BYTE_IN_PIXEL_COUNT) +
                                        (kernelY * srcBitmapData.Stride);

                            //поиск самых ярких пикселей в границах элемента
                            if (originalPixelBuffer[kernelBoundOffset] > blueByte)
                            {
                                blueByte = originalPixelBuffer[kernelBoundOffset];
                            }
                            if (originalPixelBuffer[kernelBoundOffset + 1] > greenByte)
                            {
                                greenByte = originalPixelBuffer[kernelBoundOffset + 1];
                            }
                            if (originalPixelBuffer[kernelBoundOffset + 2] > redByte)
                            {
                                redByte = originalPixelBuffer[kernelBoundOffset + 2];
                            }
                        }
                    }
                    resultPixelBuffer[anchorByteOffset] = blueByte;
                    resultPixelBuffer[anchorByteOffset + 1] = greenByte;
                    resultPixelBuffer[anchorByteOffset + 2] = redByte;
                    resultPixelBuffer[anchorByteOffset + 3] = BRIGHT_COLOR;
                }
            }

            return CreateResultBitmap(srcImage.Width, srcImage.Height, resultPixelBuffer); 
        }

        private Bitmap Erode(Bitmap srcImage, int level)
        {
            BitmapData srcBitmapData = srcImage.LockBits(new Rectangle(0, 0, srcImage.Width, 
                srcImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] originalPixelBuffer = new byte[srcBitmapData.Stride * srcBitmapData.Height];
            byte[] resultPixelBuffer = new byte[srcBitmapData.Stride * srcBitmapData.Height];

            Marshal.Copy(srcBitmapData.Scan0, originalPixelBuffer, 0, originalPixelBuffer.Length);
            srcImage.UnlockBits(srcBitmapData);

            int kernelSize = level;
            int kernelBoundOffset = 0;
            int anchorByteOffset = 0;
            byte blueByte = DARK_COLOR;
            byte greenByte = DARK_COLOR;
            byte redByte = DARK_COLOR;
            byte defaultColorValue = BRIGHT_COLOR;

            //выбираем точку-центр элемента
            for (int y = kernelSize; y < srcImage.Height - kernelSize; y++)
            {
                for (int x = kernelSize; x < srcImage.Width - kernelSize; x++)
                {
                    //номер байта ~ сдвигу по y и x
                    anchorByteOffset = y * srcBitmapData.Stride + x * BYTE_IN_PIXEL_COUNT;

                    blueByte = defaultColorValue;
                    greenByte = defaultColorValue;
                    redByte = defaultColorValue;
                    for (int kernelY = -kernelSize; kernelY <= kernelSize; kernelY++)
                    {
                        for (int kernelX = -kernelSize; kernelX <= kernelSize; kernelX++)
                        {
                            kernelBoundOffset = anchorByteOffset + (kernelX * BYTE_IN_PIXEL_COUNT) +
                                        (kernelY * srcBitmapData.Stride);

                            if (originalPixelBuffer[kernelBoundOffset] < blueByte)
                            {
                                blueByte = originalPixelBuffer[kernelBoundOffset];
                            }
                            if (originalPixelBuffer[kernelBoundOffset + 1] < greenByte)
                            {
                                greenByte = originalPixelBuffer[kernelBoundOffset + 1];
                            }
                            if (originalPixelBuffer[kernelBoundOffset + 2] < redByte)
                            {
                                redByte = originalPixelBuffer[kernelBoundOffset + 2];
                            }
                        }
                    }
                    
                    resultPixelBuffer[anchorByteOffset] = blueByte;
                    resultPixelBuffer[anchorByteOffset + 1] = greenByte;
                    resultPixelBuffer[anchorByteOffset + 2] = redByte;
                    resultPixelBuffer[anchorByteOffset + 3] = BRIGHT_COLOR;
                }
            }

            return CreateResultBitmap(srcImage.Width, srcImage.Height, resultPixelBuffer); 
        }

        private Bitmap CreateResultBitmap(int width, int height, byte[] pixels)
        {
            Bitmap resBitmap = new Bitmap(width, height);

            BitmapData resBitmapData = resBitmap.LockBits(new Rectangle(0, 0, resBitmap.Width,
                resBitmap.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(pixels, 0, resBitmapData.Scan0, pixels.Length);
            resBitmap.UnlockBits(resBitmapData);

            return resBitmap; 
        }
    }
}
