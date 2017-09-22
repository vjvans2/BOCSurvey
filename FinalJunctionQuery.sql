USE SurveyBOCPractice
GO
--created a CTE since the UNION couldn't grab the Answer Content from the first SELECT statement

CREATE PROC spBaseJunctionQueryx
	@SurveyID int
AS

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
)
SELECT SQJunction.QuestionContent, SQJunction.SurveyName, SAJunction.AnswerContent
FROM SQJunction 
INNER JOIN SAJunction ON SQJunction.SurveyName = SAJunction.SurveyName
WHERE SQJunction.QuestionID = SAJunction.AnswerID AND SAJunction.SurveyID = @SurveyID;  -- where the value turns into a parameter on pg.1



--DECLARE @SurveyID int
--EXEC spBaseJunctionQueryx @SurveyID = 1