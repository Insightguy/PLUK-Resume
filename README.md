# PLUK-Resume
API items

GET (url)/Person/Person/{id}
Gets the person by the ID number

POST (url)/Person/Person/
Greates a new person. use a JSON body with the following values:
PERSON_ID = ID of the person
PERSON_NAME = Name of the person
FATHER_ID = ID of the father, use 0 if none yet
MOTHER_ID = ID of the mother, use 0 if none yet
TREE_ID = IF of the tree
GENDER = Gender of the person


PUT (url)/Person/Person/{id}
Edits the info of the person, use the PERSON_ID to select the person, requires a JSON body, use the same format as the POST

DELETE (url)/Person/Person/{id}
Deletes the person with that ID


GET (url)/Tree/Tree/{id}
Gets the Tree by the ID number

POST (url)/Tree/Tree/
Greates a new Tree. use a JSON body with the following values:
TREE_ID = ID of the tree
TREE_NAME = Name of the tree


PUT (url)/Tree/PersTreeon/{id}
Edits the info of the Tree, use the PERSON_ID to select the Tree, requires a JSON body, use the same format as the POST

DELETE (url)/Tree/Tree/{id}
Deletes the Tree with that ID

GET (url)/TreeMaker/{id}
Gets the list of all the people under the tree. the info includes the following values:
PERSON_ID = ID of the person
PERSON_NAME = Name of the person
FATHER_ID = ID of the father, use 0 if none yet
MOTHER_ID = ID of the mother, use 0 if none yet
TREE_ID = IF of the tree
GENDER = Gender of the person

POST (url)/TreeMaker/
Links people to a tree, uses a json body.
TREE_ID = ID of the tree to use
PERSON_ID1 = person 1, the one to whom the relation is given from
RELATIONSHIP = determines the relationship of person 1 with person 2, valid values are SON, DAUGHTER, FATHER, MOTHER
PERSON_ID2 = person 2, the one to whom the relation applies to


