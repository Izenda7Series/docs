## Installing Sphinx

Follow the steps [here](http://www.sphinx-doc.org/en/1.4.8/install.html) (Be sure to install python 2.7, not 3)

Install the Sphinx RTD Theme 

     pip install sphinx_rtd_theme
    
Install the sphinx-csharp extension

     pip install sphinx-csharp
    
## Building locally

Build the static documentation and open them in your browser:

      make html
      open _build/html/index.html

Build the documentation and automatically build them on any change:

      make livehtml
      open http://127.0.0.1:8000/
