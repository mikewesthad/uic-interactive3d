#!/bin/bash
for file in */*.wav
do
    echo "$file -> ${file%.*}"

    # Trim file to 3 seconds long
    # Apply a fade out
    # Add 1 second of silence to the end
    # sox "$file" "${file%.*}-processed.wav" trim 0 3 fade t 0 3 1 pad 0 1
    # mv "${file%.*}-processed.wav" "$file"

    # Covert to ogg
    # sox "$file" "${file%.*}.ogg"
    # rm "$file"
done