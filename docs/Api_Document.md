# Project API Documentation | v1
## Version: 1.0.0

---

### 📋 API Endpoint Summary
*Click on a path to jump to its details.*

| Path | Method | Summary |
| :--- | :--- | :--- |
| [/api/Student/Course/GetAll](#apistudentcoursegetall) | `GET` | Get all courses |
| [/api/Student/Course/GetById/{id}](#apistudentcoursegetbyidid) | `GET` | Get course by ID |
| [/api/Student/Lesson/GetAll](#apistudentlessongetall) | `GET` | Get all lessons |
| [/api/Student/Lesson/GetById/{id}](#apistudentlessongetbyidid) | `GET` | Get lesson by ID |
| [/api/Student/Lesson/GetByCourseId/{courseId}](#apistudentlessongetbycourseidcourseid) | `GET` | Get lessons by course |
| [/api/Student/Quiz/GetAll](#apistudentquizgetall) | `GET` | Get all quizzes |
| [/api/Student/Quiz/GetById/{id}](#apistudentquizgetbyidid) | `GET` | Get quiz by ID |
| [/api/Student/Quran/surahs](#apistudentquransurahs) | `GET` | Get all Surahs |
| [/api/Student/Quran/surahs/{number}](#apistudentquransurahsnumber) | `GET` | Get Surah by number |
| [/api/Student/Quran/surahs/{surahNumber}/ayahs/{ayahNumber}](#apistudentquransurahssurahnumberayahsayahnumber) | `GET` | Get Ayah |
| [/api/Student/Quran/search](#apistudentquransearch) | `GET` | Search Quran |
| [/api/Student/Quran/SearchGeneric](#apistudentquransearchgeneric) | `GET` | Generic search |
| [/api/Student/User/GetMyProfile](#apistudentusergetmyprofile) | `GET` | Get profile |
| [/api/Student/User/UpdateMyProfile](#apistudentuserupdatemyprofile) | `PUT` | Update profile |
| [/api/Student/User/ChangePassword](#apistudentuserchangepassword) | `PUT` | Change password |
| [/api/Student/User/ChangeEmail](#apistudentuserchangeemail) | `PUT` | Change email |
| [/api/Student/User/ConfirmNewEmail](#apistudentuserconfirmnewemail) | `GET` | Confirm email |
| [/api/Student/UserProgress/add](#apistudentuserprogressadd) | `POST` | Add progress |
| [/api/Student/UserProgress/me](#apistudentuserprogressme) | `GET` | Get my progress |
| [/api/Student/ThikrCategory/GetAll](#apistudentthikrcategorygetall) | `GET` | Get all Thikr |
| [/api/Student/ThikrCategory/GetById/{id}](#apistudentthikrcategorygetbyidid) | `GET` | Get Thikr by ID |
| [/api/Student/ThikrCategory/Search](#apistudentthikrcategorysearch) | `GET` | Search Thikr |
| [/api/Admin/Course/Create](#apiadmincoursecreate) | `POST` | Create course |
| [/api/Admin/Course/Update/{id}](#apiadmincourseupdateid) | `PUT` | Update course |
| [/api/Admin/Course/ToggleStatus/{id}](#apiadmincoursetogglestatusid) | `PATCH` | Toggle status |
| [/api/Admin/Course/Delete/{id}](#apiadmincoursedeleteid) | `DELETE` | Delete course |

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
