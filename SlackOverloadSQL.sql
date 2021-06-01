create schema SlackOverload;
use SlackOverload;

CREATE TABLE `questions` (
  `id` mediumint(8) unsigned NOT NULL auto_increment,
  `username` varchar(20) default NULL,
  `title` varchar(150) default NULL,
  `detail` varchar(250) default NULL,
  `posted` datetime default NULL,
  `category` varchar(20),
  `status` mediumint(1) default 0,
  PRIMARY KEY (`id`)
) AUTO_INCREMENT=1;

CREATE TABLE `answers` (
  `id` mediumint(8) unsigned NOT NULL auto_increment,
  `username` varchar(20) default NULL,
  `detail` varchar(250) default NULL,
  `questionid` mediumint default NULL,
  `posted` datetime default NULL,
  PRIMARY KEY (`id`)
) AUTO_INCREMENT=1;

alter table answers modify detail nvarchar(250);

INSERT INTO `questions` (`id`,`username`,`title`,`detail`,`posted`, `category`, `status`) VALUES ("1","IndoorTooth", "Comments in C#", "How do I leave a comment while writing in C#?", now(), "C#", "1");
INSERT INTO `answers` (`id`,`username`,`detail`,`questionid`,`posted`) VALUES("1","LavaBoiii","All you need to do is type // and then type your comment! The compiler won't use any code in that line when upon running the program.", "1", now()); 
INSERT INTO `answers` (`id`,`username`,`detail`,`questionid`,`posted`) VALUES("2","SharkGirl","You can type */ ~text~ /*. Everything between */   /* will not be picked up by the compiler", "1", now());

INSERT INTO `questions` (`id`,`username`,`title`,`detail`,`posted`, `category`,`status`) VALUES ("2","CaptKirky", "Create a Table in HTML", "How do I create a table using HTML?", now(), "HTML", "0");