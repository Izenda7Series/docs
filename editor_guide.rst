:orphan:

================
Editor's Guide
================

Basic formatting
-----------------

*  reStructuredText tables will break when cell content is changed. They should never be used since Sphinx has provided a ``list-table`` directive that is much easier to maintain.

   .. list-table::
      :header-rows: 1

      *  -  Code
         -  Result
      *  -
            .. code-block:: rst

               .. list-table::
                  :header-rows: 1

                  *  -  Field
                     -  Value
                  *  -  Name
                     -  "John Doe"
         -
            .. list-table::
               :header-rows: 1

               *  -  Field
                  -  Value
               *  -  Name
                  -  "John Doe"

*  Please see http://docutils.sourceforge.net/docs/user/rst/quickref.html for other items.

Collapsible Content
--------------------

.. list-table::
   :header-rows: 1

   *  -  Code
      -  Result
   *  -
         .. code-block:: rst

            .. container:: toggle

               .. container:: header

                  Title:

               .. code-block:: json

                  {
                     "name": "John Doe"
                  }
      -
         .. container:: toggle

            .. container:: header

               Title:

            .. code-block:: json

               {
                  "name": "John Doe"
               }

Image Layout
------------

* The images are displayed in 3/4th of their original sizes to look best proportionally with the text size.
* The ``figure`` directive with ``:align: right`` option is currently used. It allows for a resonably consistent look among different screen dimensions. The "text flowing around" effect is stopped using ``|br|`` (which will be replaced by the HTML code ``<br clear="right">``).

**Examples**


Source:

.. code-block:: rst

   .. figure:: /_static/images/Connection_Delete.jpg
      :align: right
      :width: 185px

      Connection Delete

   * Lorem ipsum dolor sit amet, cum ea omnis dicant.
   * Ex eos ferri laoreet instructior.
   * No vis persius nominavi, ut aliquip viderer ius, vim eu animal consulatu. Euismod tractatos id duo. Mucius appellantur vim in, mea ne debet cetero facilis. Eu errem honestatis vis, id has adipisci prodesset. |br|

iPhone (320 pixels):
|iPhone|

.. figure:: /_static/images/Connection_Delete.jpg
   :align: right
   :width: 185px

   Connection Delete

* Lorem ipsum dolor sit amet, cum ea omnis dicant.
* Ex eos ferri laoreet instructior.
* No vis persius nominavi, ut aliquip viderer ius, vim eu animal consulatu. Euismod tractatos id duo. Mucius appellantur vim in, mea ne debet cetero facilis. Eu errem honestatis vis, id has adipisci prodesset. |br|

|divEnd|


iPad (768 pixels):
|iPad|

.. figure:: /_static/images/Connection_Delete.jpg
   :align: right
   :width: 185px

   Connection Delete

* Lorem ipsum dolor sit amet, cum ea omnis dicant.
* Ex eos ferri laoreet instructior.
* No vis persius nominavi, ut aliquip viderer ius, vim eu animal consulatu. Euismod tractatos id duo. Mucius appellantur vim in, mea ne debet cetero facilis. Eu errem honestatis vis, id has adipisci prodesset. |br|

|divEnd|


sphinx_rtd_theme (800 pixels):
|sphinx_rtd_theme|

.. figure:: /_static/images/Connection_Delete.jpg
   :align: right
   :width: 185px

   Connection Delete

* Lorem ipsum dolor sit amet, cum ea omnis dicant.
* Ex eos ferri laoreet instructior.
* No vis persius nominavi, ut aliquip viderer ius, vim eu animal consulatu. Euismod tractatos id duo. Mucius appellantur vim in, mea ne debet cetero facilis. Eu errem honestatis vis, id has adipisci prodesset. |br|

|divEnd|

Tips and Hint
----------------

*  Break a line at a specific position with ``|br|``

   A long line will be broken into a new line at a random position depending on the page width

   .. list-table::

      * - Lorem ipsum dolor sit amet, cum ea omnis dicant. Ex eos ferri laoreet instructior. No vis persius nominavi, ut aliquip viderer ius, vim eu animal consulatu. No vis persius nominavi, ut aliquip viderer ius, vim eu animal consulatu.

   To go to a new line exactly after "instructior.", add ``|br|`` after that word:

   .. list-table::

      * - Lorem ipsum dolor sit amet, cum ea omnis dicant. Ex eos ferri laoreet instructior. |br| No vis persius nominavi, ut aliquip viderer ius, vim eu animal consulatu. No vis persius nominavi, ut aliquip viderer ius, vim eu animal consulatu.

*  Format a link

   Sphinx does not support formatting a link. This syntax ``*:doc:`/index`*`` does not work: (it shows up as *:doc:`/index`*)

   The workaround is to wrap the link in a user-defined css class that performs the formatting.

.. list-table::
   :header-rows: 1

   *  -  Code
      -  Result
   *  -
         css:

         .. code-block:: css

            .italic {
               font-style: italic;
            }

         rst:

         .. code-block:: rst

            .. container:: italic

               :doc:`/index`
      -  
         .. container:: italic

            :doc:`/index`



.. |iPhone| raw:: html

   <div style="width:320px;background-color:#f9f9f9;border:1px solid #ddd;">

.. |iPad| raw:: html

   <div style="width:768px;background-color:#f9f9f9;border:1px solid #ddd;">

.. |sphinx_rtd_theme| raw:: html

   <div style="width:800px;background-color:#f9f9f9;border:1px solid #ddd;">

.. |divEnd| raw:: html

   </div>
