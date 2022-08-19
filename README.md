# Spider-Man Texture Tool
Tool for working with Marvel's Spider-Man remastered PC .texture files with batch options

# General workflow

1. Extract **.texture** asset using the [SMPT tool](https://www.nexusmods.com/marvelsspidermanremastered/mods/51)
2. Provide the tool with .texture file
3. Convert the file to **.dds** format
4. Edit the file using Photoshop with relevant plugins
5. Convert the .dds files back to .texture
6. Use the SMPT tool to put them back in the game

# Usage
 > Please contact me on nexus, discord or leave an issue in case you encounter any bug

## First Section - 'Original file'
Drag-n-drop or use 'Select' to provide path to the **.texture** file.

**Batch Mode** - sets the tool to use folders instead of specific files.

## Second Section - 'Conversion to viewable format'
The conversion is done with RawTex. The tool can detect the size of the texture automatically (which is the recommended parameter)
and convert using different formats e.g BC1, BC7... I would recommend checking different options if BC7 gives pixelated results.

**Non local** - makes you save file to different folder after conversion. In **Batch Mode** the converted files are stored in a single folder specified by the user. 

*Try the BC1 up to BC6 if the conversion is pixelated*

## Third Section - 'Conversion to game format'

Select the location of the .dds file to convert it back to .texture format. This will overwrite the original .texture file.

**Back up .dds** - originally the .dds are deleted after conversion, keep this ON to prevent deletion.

In **Batch Mode** only folders can be selected. If **Non-local** option is selected, make sure to select the folder where the converted batch is located. Otherwise select the same path from the first section.

# General Tips:

1. Try to convert _your_ **.texture** files back to **.dds** to check if the conversion was truly successful.
2. Make sure to not mix up the paths.
3. If one of the conversion formats where successful (e.g BC7) use the same format in the Photoshop plugin to save them.

# Photoshop plugins
* [Nvidia](https://developer.nvidia.com/nvidia-texture-tools-exporter)
* [Intel](https://www.intel.com/content/www/us/en/developer/articles/tool/intel-texture-works-plugin.html)

## Discord
> neol#3374
