﻿namespace DayzMapsLoader.DataTypes;

internal class ImageSet
{
    private readonly ProviderImage[,] _images;

    public ImageSet(int w, int h)
    {
        _images = new ProviderImage[w, h];
    }

    public int Weight => _images.GetLength(0);
    public int Height => _images.GetLength(1);

    public ProviderImage GetImage(int x, int y)
    {
        return _images[x, y];
    }

    public void SetImage(int x, int y, ProviderImage img)
    {
        _images[x, y] = img;
    }
}