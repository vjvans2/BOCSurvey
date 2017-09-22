--USE SurveyBOCPractice
--GO
----created a CTE since the UNION couldn't grab the Answer Content from the first SELECT statement

--CREATE PROC spDistinctNamesQuery
--AS

WITH 
SQJunction AS
(
SELECT  QuestionContent, SurveyName, QuestionsPractice.QuestionID
FROM SurveyQuestionPractice
JOIN QuestionsPractice ON QuestionsPractice.QuestionID = SurveyQuestionPractice.QuestionID
JOIN SurveysPractice ON SurveysPractice.SurveyID = SurveyQuestionPractice.SurveyID
),
SAJunction AS
(
SELECT SurveyName, AnswerContent, AnswersPractice.AnswerID, SurveysPractice.SurveyID
FROM SurveyAnswerPractice
JOIN SurveysPractice ON SurveysPractice.SurveyID = SurveyAnswerPractice.SurveyID
JOIN AnswersPractice ON AnswersPractice.AnswerID = SurveyAnswerPractice.AnswerID
),
Final AS
(
SELECT SQJunction.QuestionContent, SQJunction.SurveyName, SAJunction.AnswerContent, SAJunction.SurveyID
FROM SQJunction 
INNER JOIN SAJunction ON SQJunction.SurveyName = SAJunction.SurveyName
WHERE SQJunction.QuestionID = SAJunction.AnswerID
)
SELECT Final.SurveyName
FROM Final
GROUP BY Final.SurveyID, Final.SurveyName;