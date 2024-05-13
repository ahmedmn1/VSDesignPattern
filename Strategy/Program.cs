// See https://aka.ms/new-console-template for more information
using Strategy;

//Startegy Pattern, same like state. the main difference is two: 1- state pattern: if a single state change, multiple behaviours change on canvas object
//2- Starategy, if multiple state change(compressor, filter), single behavior(Store method) will change 

ImageStore imageStore = new
    (new JpegCompressor(), new BlackAndWhiteFilter());

imageStore.Store("filePath");

//note we can call the constructor more than one time as the constructor is just a method
imageStore = new
    (new PngCompressor() , new HighContrastFilter() );

imageStore.Store("filePath");





