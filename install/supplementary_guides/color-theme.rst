======================================
Color theme for Chart, Gauge, and Map
======================================


Introduction
------------------------------------------
* Izenda v2.9.0 and higher provides a pre-defined list of color themes, application administrator can also customize the available list. 

* The color theme list is available for the following purposes:

   - Set default color theme for System or Tenant level.

   - Customize the color theme applying Chart, Gauge or Map report parts.

Configuration
-----------------------
* In API > Themes folder, application administrators can add or update color themes by adding new files or updating existing files.

.. _Color_Theme_File:

* A color theme file is a JSON file that contains an array of HEX color codes |br|

   **Example:** The *mariner.JSON* is a color theme file with the content:

   .. code-block:: JSON

      {
         "colors": ["#2f7ed8", "#0d233a", "#8bbc21", "#910000", "#1aadce", "#492970", "#f28f43", "#77a1e5", "#c42525", "#a6c96a", "#d86524", "#707cd3"]
      }

.. note::

   * The new and update file only load and apply when administrators restart the server.
   * One file must contain one and only one color theme.