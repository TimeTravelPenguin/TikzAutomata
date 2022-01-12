# How to compile

Run the following commands in the command-line for each `.tex`, `.pdf`, and `.svg` file:

```console
pdflatex latex_filename.tex
pdf2svg pdf_filename.pdf image_filename.svg
inkscape image_filename.svg -o image_filename.png -w width
```

`pdflatex`, `pdf2svg`, and `inkscape` must be installed and added to the environment variables.
