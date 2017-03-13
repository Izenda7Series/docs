===========================================
Available Calculated Field Expressions
===========================================

.. list-table::
   :header-rows: 1
   :widths: 20 80

   *  -  Function Name
      -  Syntax
   *  -  expression
      -  expression
   *  -  \+ 
      -  expression + expression
   *  -  \- 
      -  expression - expression
   *  -  / 
      -  expression / expression
   *  -  < 
      -  expression < expression
   *  -  <= 
      -  expression <= expression
   *  -  <> 
      -  expression <> expression
   *  -  = 
      -  expression = expression
   *  -  > 
      -  expression > expression
   *  -  >= 
      -  expression >= expression
   *  -  AND 
      -  boolean_expression AND boolean_expression
   *  -  AVG 
      -  AVG (expression)
   *  -  BETWEEN 
      -  BETWEEN (test_expression, begin_expression, end_expression)
   *  -  CASE WHEN...THEN...ELSE...END 
      -  CASE WHEN (boolean_expression) THEN (result_expression) [...n] [ELSE (else_result_expression)] END
   *  -  CASE...WHEN...THEN...ELSE...END 
      -  CASE (input_expression) WHEN (when_expression) THEN (result_expression) [...n] [ELSE (else_result_expression)] END
   *  -  CAST...AS 
      -  CAST (expression AS data_type)
   *  -  CHAR 
      -  CHAR (integer_expression)
   *  -  CONCAT 
      -  CONCAT (expression, expression[,expression...])
   *  -  CONVERT 
      -  CONVERT (data_type [( length)], expression[, style])
   *  -  COUNT 
      -  COUNT (expression)
   *  -  DATEADD 
      -  DATEADD (datepart, number, expression)
   *  -  DATEDIFF 
      -  DATEDIFF (datepart, startdate, enddate)
   *  -  DATEPART 
      -  DATEPART (datepart, date)
   *  -  DISTINCT 
      -  DISTINCT (column) or DISTINCT column
   *  -  GETDATE 
      -  GETDATE ()
   *  -  IF...THEN...ELSE...END 
      -  IF (boolean_expression) THEN (true_expression) [ELSE (false_expression)] END
   *  -  IIF 
      -  IIF (boolean_expression, true_expression, [false_expression])
   *  -  ISNULL 
      -  ISNULL (check_expression, replacement_value)
   *  -  LEFT 
      -  LEFT (character_expression, integer_expression)
   *  -  LEN 
      -  LEN (expression)
   *  -  LTRIM 
      -  LTRIM (character_expression)
   *  -  MAX 
      -  MAX (expression)
   *  -  MIN 
      -  MIN (expression)
   *  -  NOTBETWEEN 
      -  NOTBETWEEN (test_expression, begin_expression, end_expression)
   *  -  OR 
      -  boolean_expression OR boolean_expression
   *  -  REPLACE 
      -  REPLACE (string_expression, string_pattern, string_replacement)
   *  -  RIGHT 
      -  RIGHT (character_expression, integer_expression)
   *  -  ROUND 
      -  ROUND (expression, length[, function])
   *  -  RTRIM 
      -  RTRIM (character_expression)
   *  -  RUNNING AVG 
      -  RUNNINGAVG (column)
   *  -  RUNNING COUNT 
      -  RUNNINGCOUNT (column)
   *  -  RUNNING SUM 
      -  RUNNINGSUM (column)
   *  -  SUBSTRING 
      -  SUBSTRING (expression, start, length)
   *  -  SUM 
      -  SUM (expression)
