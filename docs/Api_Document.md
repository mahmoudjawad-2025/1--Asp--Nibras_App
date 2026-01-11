# Project API Documentation | v1
## Version: 1.0.0

---

| Path | Method | Summary |
| :--- | :--- | :--- |
| [/api/Admin/Category/Create](#apiadmincategorycreate) | `POST` | Create Category |
| [/api/Admin/Category/Delete/{id}](#apiadmincategorydeleteid) | `DELETE` | Delete Category |
| [/api/Admin/Category/GetAll](#apiadmincategorygetall) | `GET` | Get All Categories |
| [/api/Admin/Category/GetById/{id}](#apiadmincategorygetbyidid) | `GET` | Get Category By ID |
| [/api/Admin/Category/ToggleStatus/{id}](#apiadmincategorytogglestatusid) | `PATCH` | Toggle Category Status |
| [/api/Admin/Category/Update/{id}](#apiadmincategoryupdateid) | `PATCH` | Update Category |
| [/api/Admin/Course/Create](#apiadmincoursecreate) | `POST` | Create Course |
| [/api/Admin/Course/Delete/{id}](#apiadmincoursedeleteid) | `DELETE` | Delete Course |
| [/api/Admin/Course/GetAll](#apiadmincoursegetall) | `GET` | Get All Courses |
| [/api/Admin/Course/GetById/{id}](#apiadmincoursegetbyidid) | `GET` | Get Course By ID |
| [/api/Admin/Course/ToggleStatus/{id}](#apiadmincoursetogglestatusid) | `PATCH` | Toggle Course Status |
| [/api/Admin/Course/Update/{id}](#apiadmincourseupdateid) | `PUT` | Update Course |
| [/api/Admin/HadithBooks/Create](#apiadminhadithbookscreate) | `POST` | Create Hadith Book |
| [/api/Admin/HadithBooks/Delete/{id}](#apiadminhadithbooksdeleteid) | `DELETE` | Delete Hadith Book |
| [/api/Admin/HadithBooks/GetAll](#apiadminhadithbooksgetall) | `GET` | Get All Hadith Books |
| [/api/Admin/HadithBooks/GetById/{id}](#apiadminhadithbooksgetbyidid) | `GET` | Get Hadith Book By ID |
| [/api/Admin/HadithBooks/Search](#apiadminhadithbookssearch) | `GET` | Search Hadith Books |
| [/api/Admin/HadithBooks/ToggleStatus/{id}](#apiadminhadithbookstogglestatusid) | `PATCH` | Toggle Book Status |
| [/api/Admin/HadithBooks/Update/{id}](#apiadminhadithbooksupdateid) | `PUT` | Update Hadith Book |
| [/api/Admin/HadithBooks/{id}/chapters](#apiadminhadithbooksidchapters) | `GET` | Get Chapters by Book |
| [/api/Admin/HadithBooks/{id}/hadiths](#apiadminhadithbooksidhadiths) | `GET` | Get Hadiths by Book |
| [/api/Admin/HadithBooks/{id}/random](#apiadminhadithbooksidrandom) | `GET` | Get Random Hadith |
| [/api/Admin/HadithBooks/{id}/stats](#apiadminhadithbooksidstats) | `GET` | Get Book Stats |
| [/api/Admin/HadithChapters/Create](#apiadminhadithchapterscreate) | `POST` | Create Chapter |
| [/api/Admin/HadithChapters/Delete/{id}](#apiadminhadithchaptersdeleteid) | `DELETE` | Delete Chapter |
| [/api/Admin/HadithChapters/GetAll](#apiadminhadithchaptersgetall) | `GET` | Get All Chapters |
| [/api/Admin/HadithChapters/GetById/{id}](#apiadminhadithchaptersgetbyidid) | `GET` | Get Chapter By ID |
| [/api/Admin/HadithChapters/Search](#apiadminhadithchapterssearch) | `GET` | Search Chapters |
| [/api/Admin/HadithChapters/ToggleStatus/{id}](#apiadminhadithchapterstogglestatusid) | `PATCH` | Toggle Chapter Status |
| [/api/Admin/HadithChapters/Update/{id}](#apiadminhadithchaptersupdateid) | `PUT` | Update Chapter |
| [/api/Admin/HadithChapters/book/{bookId}](#apiadminhadithchaptersbookbookid) | `GET` | Get Chapters by Book ID |
| [/api/Admin/HadithChapters/{id}/hadiths](#apiadminhadithchaptersidhadiths) | `GET` | Get Hadiths by Chapter |
| [/api/Admin/Hadiths/Create](#apiadminhadithscreate) | `POST` | Create Hadith |
| [/api/Admin/Hadiths/Delete/{id}](#apiadminhadithsdeleteid) | `DELETE` | Delete Hadith |
| [/api/Admin/Hadiths/GetAll](#apiadminhadithsgetall) | `GET` | Get All Hadiths |
| [/api/Admin/Hadiths/Search](#apiadminhadithssearch) | `GET` | Search Hadiths |
| [/api/Admin/Lesson/Create](#apiadminlessoncreate) | `POST` | Create Lesson |
| [/api/Admin/Lesson/Delete/{id}](#apiadminlessondeleteid) | `DELETE` | Delete Lesson |
| [/api/Admin/Lesson/GetAll](#apiadminlessongetall) | `GET` | Get All Lessons |
| [/api/Admin/Lesson/GetByCourseId/{courseId}](#apiadminlessongetbycourseidcourseid) | `GET` | Get Lessons by Course |
| [/api/Admin/Quiz/Create](#apiadminquizcreate) | `POST` | Create Quiz |
| [/api/Admin/Quiz/GetAll](#apiadminquizgetall) | `GET` | Get All Quizzes |
| [/api/Admin/Quran/surahs](#apiadminquransurahs) | `GET` | Get All Surahs |
| [/api/Admin/Quran/search](#apiadminquransearch) | `GET` | Search Quran |
| [/api/Admin/ThikrCategory/Create](#apiadminthikrcategorycreate) | `POST` | Create Thikr Category |
| [/api/Admin/ThikrCategory/GetAll](#apiadminthikrcategorygetall) | `GET` | Get All Thikr Categories |
| [/api/Admin/ThikrItem/Create](#apiadminthikritemcreate) | `POST` | Create Thikr Item |
| [/api/Admin/User/GetAllUsers](#apiadminusergetallusers) | `GET` | Get All Users |
| [/api/Admin/User/BlockUser/{userId}](#apiadminuserblockuseruserid) | `PATCH` | Block User |
| [/api/Admin/User/UpdateMyProfile](#apiadminuserupdatemyprofile) | `PUT` | Update Profile |
| [/api/Identity/Authentication/Login](#apiidentityauthenticationlogin) | `POST` | User Login |
| [/api/Identity/Authentication/Register](#apiidentityauthenticationregister) | `POST` | User Registration |
| [/api/Student/Course/GetAll](#apistudentcoursegetall) | `GET` | Get All Courses |
| [/api/Student/Quran/surahs](#apistudentquransurahs) | `GET` | Get Surahs |
| [/api/Student/HadithBooks/GetAll](#apistudenthadithbooksgetall) | `GET` | Get Hadith Books |



---

## Endpoint Details

### /api/Student/Course/GetAll
#### GET
##### Responses
| Code | Description |
| ---- | ----------- |
| 200 | OK |

---

### /api/Student/Course/GetById/{id}
#### GET
##### Parameters
| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path | | Yes | integer |

##### Responses
| Code | Description |
| ---- | ----------- |
| 200 | OK |

---

### /api/Student/Lesson/GetAll
#### GET
##### Responses
| Code | Description |
| ---- | ----------- |
| 200 | OK |

---

### /api/Student/Lesson/GetById/{id}
#### GET
##### Parameters
| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path | | Yes | integer |

##### Responses
| Code | Description |
| ---- | ----------- |
| 200 | OK |

---

### /api/Student/Lesson/GetByCourseId/{courseId}
#### GET
##### Parameters
| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| courseId | path | | Yes | integer |

##### Responses
| Code | Description |
| ---- | ----------- |
| 200 | OK |

---

### /api/Student/Quiz/GetAll
#### GET
##### Responses
| Code | Description |
| ---- | ----------- |
| 200 | OK |

---

### /api/Student/Quiz/GetById/{id}
#### GET
##### Parameters
| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path | | Yes | integer |

##### Responses
| Code | Description |
| ---- | ----------- |
| 200 | OK |

---

### /api/Student/Quran/surahs
#### GET
##### Responses
| Code | Description |
| ---- | ----------- |
| 200 | OK |

---

### /api/Student/Quran/surahs/{number}
#### GET
##### Parameters
| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| number | path | | Yes | integer |

##### Responses
| Code | Description |
| ---- | ----------- |
| 200 | OK |

---

### /api/Student/Quran/surahs/{surahNumber}/ayahs/{ayahNumber}
#### GET
##### Parameters
| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| surahNumber | path | | Yes | integer |
| ayahNumber | path | | Yes | integer |

##### Responses
| Code | Description |
| ---- | ----------- |
| 200 | OK |

---

### /api/Student/Quran/search
#### GET
##### Parameters
| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| q | query | | No | string |
| limit | query | | No | integer |

##### Responses
| Code | Description |
| ---- | ----------- |
| 200 | OK |

---

### /api/Student/Quran/SearchGeneric
#### GET
##### Parameters
| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| query | query | | No | string |

##### Responses
| Code | Description |
| ---- | ----------- |
| 200 | OK |

---

### /api/Admin/Course/Create
#### POST
##### Responses
| Code | Description |
| ---- | ----------- |
| 200 | OK |

---

### /api/Admin/Course/Update/{id}
#### PUT
##### Parameters
| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path | | Yes | integer |

##### Responses
| Code | Description |
| ---- | ----------- |
| 200 | OK |

---

### /api/Admin/Course/ToggleStatus/{id}
#### PATCH
##### Parameters
| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path | | Yes | integer |

##### Responses
| Code | Description |
| ---- | ----------- |
| 200 | OK |

<br>
<br>
<br>

### /api/Student/Course/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Course/GetById/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Lesson/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Lesson/GetById/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Lesson/GetByCourseId/{courseId}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| courseId | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Quiz/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Quiz/GetById/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Quran/surahs

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Quran/surahs/{number}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| number | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Quran/surahs/{surahNumber}/ayahs/{ayahNumber}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| surahNumber | path |  | Yes | integer |
| ayahNumber | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Quran/search

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| q | query |  | No | string |
| limit | query |  | No | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Quran/SearchGeneric

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| query | query |  | No | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/User/GetMyProfile

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/User/UpdateMyProfile

#### PUT
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/User/ChangePassword

#### PUT
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/User/ChangeEmail

#### PUT
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/User/ConfirmNewEmail

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| userId | query |  | No | string |
| token | query |  | No | string |
| newEmail | query |  | No | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/UserProgress/add

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/UserProgress/me

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/ThikrCategory/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/ThikrCategory/GetById/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/ThikrCategory/Search

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| query | query |  | No | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/ThikrItem/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/ThikrItem/GetById/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/ThikrItem/GetByCategoryId/{categoryId}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| categoryId | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/ThikrItem/Search

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| query | query |  | No | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/ThikrItem/GetByCount

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| minCount | query |  | No | integer |
| maxCount | query |  | No | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/HadithBooks/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/HadithBooks/GetById/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/HadithBooks/Search

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| query | query |  | No | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/HadithBooks/{id}/chapters

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/HadithBooks/{id}/hadiths

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/HadithBooks/{id}/random

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/HadithBooks/{id}/stats

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/HadithChapters/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/HadithChapters/GetById/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/HadithChapters/book/{bookId}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| bookId | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/HadithChapters/Search

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| query | query |  | No | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/HadithChapters/{id}/hadiths

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/HadithChapters/{id}/random

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/HadithChapters/{id}/stats

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Hadiths/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Hadiths/GetById/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Hadiths/chapter/{chapterId}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| chapterId | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Hadiths/book/{bookId}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| bookId | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Hadiths/Search

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| query | query |  | No | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Hadiths/englishNarrator/{name}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| name | path |  | Yes | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Hadiths/random

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| bookId | query |  | No | integer |
| chapterId | query |  | No | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Hadiths/stats

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Course/Create

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Course/Update/{id}

#### PUT
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Course/ToggleStatus/{id}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Course/Delete/{id}

#### DELETE
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Course/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Course/GetById/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Lesson/Create

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Lesson/Update/{id}

#### PUT
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Lesson/Delete/{id}

#### DELETE
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Lesson/ToggleStatus/{id}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Lesson/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Lesson/GetById/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Lesson/GetByCourseId/{courseId}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| courseId | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Quiz/Create

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Quiz/Update/{id}

#### PUT
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Quiz/ToggleStatus/{id}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Quiz/Delete/{id}

#### DELETE
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Quiz/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Quiz/GetById/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Quran/surahs

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Quran/surahs/{number}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| number | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Quran/surahs/{surahNumber}/ayahs/{ayahNumber}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| surahNumber | path |  | Yes | integer |
| ayahNumber | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Quran/search

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| q | query |  | No | string |
| limit | query |  | No | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Quran/SearchGeneric

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| query | query |  | No | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/User/GetAllUsers

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/User/GetUserById/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/User/BlockUser/{userId}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| userId | path |  | Yes | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/User/UnBlockUser/{userId}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| userId | path |  | Yes | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/User/IsBlockedUser/{userId}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| userId | path |  | Yes | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/User/ChangeRole/{userId}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| userId | path |  | Yes | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/User/GetMyProfile

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/User/UpdateMyProfile

#### PUT
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/User/ChangePassword

#### PUT
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/User/ChangeEmail

#### PUT
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/User/ConfirmNewEmail

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| userId | query |  | No | string |
| token | query |  | No | string |
| newEmail | query |  | No | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/UserProgress/add

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/UserProgress/me

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/ThikrCategory/GetAudioUrls

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/ThikrCategory/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/ThikrCategory/GetById/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/ThikrCategory/Search

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| query | query |  | No | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/ThikrCategory/Create

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/ThikrCategory/Update/{id}

#### PUT
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/ThikrCategory/Delete/{id}

#### DELETE
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/ThikrCategory/ToggleStatus/{id}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/ThikrItem/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/ThikrItem/GetById/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/ThikrItem/GetByCategoryId/{categoryId}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| categoryId | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/ThikrItem/Search

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| query | query |  | No | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/ThikrItem/GetByCount

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| minCount | query |  | No | integer |
| maxCount | query |  | No | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/ThikrItem/Create

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/ThikrItem/Update/{id}

#### PUT
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/ThikrItem/Delete/{id}

#### DELETE
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/ThikrItem/ToggleStatus/{id}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithBooks/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithBooks/GetById/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithBooks/Search

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| query | query |  | No | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithBooks/{id}/chapters

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithBooks/{id}/hadiths

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithBooks/{id}/random

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithBooks/{id}/stats

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithBooks/Create

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithBooks/Update/{id}

#### PUT
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithBooks/Delete/{id}

#### DELETE
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithBooks/ToggleStatus/{id}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithChapters/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithChapters/GetById/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithChapters/book/{bookId}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| bookId | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithChapters/Search

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| query | query |  | No | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithChapters/{id}/hadiths

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithChapters/{id}/random

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithChapters/{id}/stats

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithChapters/Create

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithChapters/Update/{id}

#### PUT
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithChapters/Delete/{id}

#### DELETE
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/HadithChapters/ToggleStatus/{id}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Hadiths/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Hadiths/GetById/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Hadiths/chapter/{chapterId}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| chapterId | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Hadiths/book/{bookId}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| bookId | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Hadiths/Search

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| query | query |  | No | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Hadiths/englishNarrator/{name}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| name | path |  | Yes | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Hadiths/random

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| bookId | query |  | No | integer |
| chapterId | query |  | No | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Hadiths/stats

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Hadiths/Create

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Hadiths/Update/{id}

#### PUT
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Hadiths/Delete/{id}

#### DELETE
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Hadiths/ToggleStatus/{id}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Category/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Student/Category/GetById/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Identity/Authentication/Refresh

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Identity/Authentication/Register

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Identity/Authentication/Login

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Identity/Authentication/Logout

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Identity/Authentication/ConfirmEmail

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| token | query |  | No | string |
| userId | query |  | No | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Identity/Authentication/ForgotPassword

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Identity/Authentication/ResetPassword

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Category/GetAll

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Category/GetById/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Category/Create

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Category/Update/{id}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Category/ToggleStatus/{id}

#### PATCH
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### /api/Admin/Category/Delete/{id}

#### DELETE
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | integer |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | OK |

### Models


#### ChangeEmailRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| newEmail | string |  | No |

#### ChangePasswordRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| currentPassword | string |  | No |
| newPassword | string |  | No |

#### ChangeRoleRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| roleName | string |  | No |

#### FilesTypes

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| FilesTypes | integer |  |  |

#### ForgotPasswordRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| email | string |  | No |

#### HadithBookRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| arabicTitle | string |  | No |
| arabicAuthor | string |  | No |
| arabicIntroduction | string |  | No |
| englishTitle | string |  | No |
| englishAuthor | string |  | No |
| englishIntroduction | string |  | No |

#### HadithChapterRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| arabicTitle | string |  | No |
| englishTitle | string |  | No |
| hadithBookId | integer |  | No |

#### HadithRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| idInBook | integer |  | No |
| arabicText | string |  | No |
| normalizedText | string |  | No |
| englishNarrator | string |  | No |
| englishText | string |  | No |
| hadithChapterId | integer |  | No |
| hadithBookId | integer |  | No |

#### IFormFile

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| IFormFile | string |  |  |

#### LoginRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| email | string |  | No |
| password | string |  | No |

#### ProgressCreateRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| type | [ProgressType](#progresstype) |  | No |
| relatedItemId | integer |  | No |
| count | integer |  | No |

#### ProgressType

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| ProgressType |  |  |  |

#### QuestionRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| text | string |  | No |
| correctAnswer | string |  | No |
| options | [ string ] |  | No |

#### QuizRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| title | string |  | No |
| lessonId | integer |  | No |
| questions | [ [QuestionRequest](#questionrequest) ] |  | No |

#### RefreshTokenRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| refreshToken | string |  | No |

#### RegisterRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| fullName | string |  | No |
| userName | string |  | No |
| email | string |  | No |
| password | string |  | No |
| phoneNumber | string |  | No |

#### ResetPasswordRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| newPassword | string |  | No |
| email | string |  | No |
| code | string |  | No |

#### ThikrCategoryRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| title | string |  | No |
| normalizedText | string |  | No |
| audioUrl | string |  | No |

#### ThikrItemRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| text | string |  | No |
| normalizedText | string |  | No |
| count | integer |  | No |
| description | string |  | No |
| reference | string |  | No |
| thikrCategoryId | integer |  | No |

#### UpdateProfileRequest

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| fullName | string |  | No |
| userName | string |  | No |
| phoneNumber | string |  | No |
| city | string |  | No |
| street | string |  | No |

#### UserDto

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| accessToken | string |  | No |
| refreshToken | string |  | No |
