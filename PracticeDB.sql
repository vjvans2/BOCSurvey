CREATE DATABASE SurveyBOCPractice

GO

USE SurveyBOCPractice

CREATE TABLE QuestionsPractice
(
QuestionID			INT				NOT NULL IDENTITY PRIMARY KEY,
QuestionContent		VARCHAR(150)	NOT NULL
)

CREATE TABLE SurveysPractice
(
SurveyID			INT				NOT NULL IDENTITY PRIMARY KEY,
SurveyName			VARCHAR(20)		NOT NULL
)

CREATE TABLE AnswersPractice
(
AnswerID			INT				NOT NULL IDENTITY PRIMARY KEY,
AnswerContent		VARCHAR(10)		NOT NULL
)

CREATE TABLE SurveyQuestionPractice
(
QuestionID			INT				NOT NULL, 
SurveyID			INT				NOT NULL, 
CONSTRAINT PK_SurveyQuestionPractice 
PRIMARY KEY (QuestionID, SurveyID),
FOREIGN KEY (SurveyID) REFERENCES SurveysPractice(SurveyID),
FOREIGN KEY (QuestionID) REFERENCES QuestionsPractice(QuestionID)
)


CREATE TABLE SurveyAnswerPractice
(
SurveyID			INT				NOT NULL,
AnswerID			INT				NOT NULL,
CONSTRAINT PK_SurveyAnswerPractice
PRIMARY KEY (SurveyID, AnswerID),
FOREIGN KEY (SurveyID) REFERENCES SurveysPractice(SurveyID),
FOREIGN KEY (AnswerID) REFERENCES AnswersPractice(AnswerID)
);

GO