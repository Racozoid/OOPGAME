using System;
using Godot;

// Вспомогательный класс импортирующий изображения
namespace OOPGAME.Utilities
{
    public static class ImageLoader
    {
        private static Image _Image = new Image();
        private static ImageTexture _ImageTexture = new ImageTexture();

        public static ImageTexture LoadTexture(string path, bool isPixelTexture)
        {
            _Image.Load(path);

            if (isPixelTexture)
                _ImageTexture.CreateFromImage(_Image, 0); // Загружаем изображение без сглаживания
            else
                _ImageTexture.CreateFromImage(_Image);  // Загружаем изображение со сглаживанием


            return _ImageTexture;
        }

    }
}
