======================================
Color theme for Chart, Gauge, and Map
======================================


Introduction
------------------------------------------
Izenda v2.9.0 and higher allows application administrators to configure color themes for Chart, Gauge, and Map. All themes are available for both system and tenant users.

Configuration
-----------------------
* In API > Themes folder, application administrators can add or update a color theme by adding a new file or updating an existing file.

* A color theme file is a JSON file that contains the following properties: |br|

   \- **name**: The name of the theme |br|
   \- **colors**: An array of HEX color code


   **Example:** The mariner.JSON is a color theme file with the content:

   .. code-block:: JSON

      {
         "name": "Mariner",
         "colors": ["#2f7ed8", "#0d233a", "#8bbc21", "#910000", "#1aadce", "#492970", "#f28f43", "#77a1e5", "#c42525", "#a6c96a", "#d86524", "#707cd3"]
      }

.. note::

   * The new and update file only load and apply when administrators restart the server.
   * One file must contain one and only one color theme.
   * The limitation for the number of colors in each theme is 12. In case excedding the limitation, system will load and populate the first 12 colors.
   * When a theme has invalid color(s), the system will skip and load the others.