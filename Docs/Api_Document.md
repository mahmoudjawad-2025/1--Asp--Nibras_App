# Project API Documentation | v1
## Version: 1.0.0

<br>

---

<br>

### 📋 API Endpoints Reference

| Path | Method | Summary |
| :--- | :--- | :--- |
| [/api/Student/Course/GetAll](#apistudentcoursegetall) | `GET` | Get all student courses |
| [/api/Student/Course/GetById/{id}](#apistudentcoursegetbyidid) | `GET` | Get student course by ID |
| [/api/Student/Lesson/GetAll](#apistudentlessongetall) | `GET` | Get all student lessons |
| [/api/Student/Lesson/GetById/{id}](#apistudentlessongetbyidid) | `GET` | Get student lesson by ID |
| [/api/Student/Lesson/GetByCourseId/{courseId}](#apistudentlessongetbycourseidcourseid) | `GET` | Get lessons by course |
| [/api/Student/Quiz/GetAll](#apistudentquizgetall) | `GET` | Get all student quizzes |
| [/api/Student/Quiz/GetById/{id}](#apistudentquizgetbyidid) | `GET` | Get student quiz by ID |
| [/api/Student/Quran/surahs](#apistudentquransurahs) | `GET` | List all Surahs |
| [/api/Student/Quran/surahs/{number}](#apistudentquransurahsnumber) | `GET` | Get Surah details |
| [/api/Student/Quran/surahs/{surahNumber}/ayahs/{ayahNumber}](#apistudentquransurahssurahnumberayahsayahnumber) | `GET` | Get specific Ayah |
| [/api/Student/Quran/search](#apistudentquransearch) | `GET` | Search Quran text |
| [/api/Student/Quran/SearchGeneric](#apistudentquransearchgeneric) | `GET` | Generic search |
| [/api/Student/User/GetMyProfile](#apistudentusergetmyprofile) | `GET` | View profile |
| [/api/Student/User/UpdateMyProfile](#apistudentuserupdatemyprofile) | `PUT` | Update profile |
| [/api/Student/User/ChangePassword](#apistudentuserchangepassword) | `PUT` | Security update |
| [/api/Student/User/ChangeEmail](#apistudentuserchangeemail) | `PUT` | Email update |
| [/api/Student/User/ConfirmNewEmail](#apistudentuserconfirmnewemail) | `GET` | Confirm change |
| [/api/Student/UserProgress/add](#apistudentuserprogressadd) | `POST` | Record progress |
| [/api/Student/UserProgress/me](#apistudentuserprogressme) | `GET` | View my stats |
| [/api/Student/ThikrCategory/GetAll](#apistudentthikrcategorygetall) | `GET` | All Thikr Categories |
| [/api/Student/ThikrCategory/GetById/{id}](#apistudentthikrcategorygetbyidid) | `GET` | Thikr Category details |
| [/api/Student/ThikrCategory/Search](#apistudentthikrcategorysearch) | `GET` | Search Thikr Category |
| [/api/Student/ThikrItem/GetAll](#apistudentthikritemgetall) | `GET` | All Thikr Items |
| [/api/Student/ThikrItem/GetById/{id}](#apistudentthikritemgetbyidid) | `GET` | Thikr Item details |
| [/api/Student/ThikrItem/GetByCategoryId/{categoryId}](#apistudentthikritemgetbycategoryidcategoryid) | `GET` | Items by category |
| [/api/Student/ThikrItem/Search](#apistudentthikritemsearch) | `GET` | Search Thikr Items |
| [/api/Student/ThikrItem/GetByCount](#apistudentthikritemgetbycount) | `GET` | Filter by count |
| [/api/Student/HadithBooks/GetAll](#apistudenthadithbooksgetall) | `GET` | List Hadith books |
| [/api/Student/HadithBooks/GetById/{id}](#apistudenthadithbooksgetbyidid) | `GET` | Book details |
| [/api/Student/HadithBooks/Search](#apistudenthadithbookssearch) | `GET` | Search books |
| [/api/Student/HadithBooks/{id}/chapters](#apistudenthadithbooksidchapters) | `GET` | Chapters in book |
| [/api/Student/HadithBooks/{id}/hadiths](#apistudenthadithbooksidhadiths) | `GET` | Hadiths in book |
| [/api/Student/HadithBooks/{id}/random](#apistudenthadithbooksidrandom) | `GET` | Get random from book |
| [/api/Student/HadithBooks/{id}/stats](#apistudenthadithbooksidstats) | `GET` | Book analytics |
| [/api/Student/HadithChapters/GetAll](#apistudenthadithchaptersgetall) | `GET` | All chapters |
| [/api/Student/HadithChapters/GetById/{id}](#apistudenthadithchaptersgetbyidid) | `GET` | Chapter details |
| [/api/Student/HadithChapters/book/{bookId}](#apistudenthadithchaptersbookbookid) | `GET` | Chapters by book |
| [/api/Student/HadithChapters/Search](#apistudenthadithchapterssearch) | `GET` | Search chapters |
| [/api/Student/HadithChapters/{id}/hadiths](#apistudenthadithchaptersidhadiths) | `GET` | Hadiths in chapter |
| [/api/Student/HadithChapters/{id}/random](#apistudenthadithchaptersidrandom) | `GET` | Random from chapter |
| [/api/Student/HadithChapters/{id}/stats](#apistudenthadithchaptersidstats) | `GET` | Chapter stats |
| [/api/Student/Hadiths/GetAll](#apistudenthadithsgetall) | `GET` | All Hadiths |
| [/api/Student/Hadiths/GetById/{id}](#apistudenthadithsgetbyidid) | `GET` | Hadith details |
| [/api/Student/Hadiths/chapter/{chapterId}](#apistudenthadithschapterchapterid) | `GET` | Filter by chapter |
| [/api/Student/Hadiths/book/{bookId}](#apistudenthadithsbookbookid) | `GET` | Filter by book |
| [/api/Student/Hadiths/Search](#apistudenthadithssearch) | `GET` | Search Hadith text |
| [/api/Student/Hadiths/englishNarrator/{name}](#apistudenthadithsenglishnarratorname) | `GET` | Filter by narrator |
| [/api/Student/Hadiths/random](#apistudenthadithsrandom) | `GET` | Get random Hadith |
| [/api/Student/Hadiths/stats](#apistudenthadithsstats) | `GET` | Global Hadith stats |
| [/api/Admin/Course/Create](#apiadmincoursecreate) | `POST` | Create course |
| [/api/Admin/Course/Update/{id}](#apiadmincourseupdateid) | `PUT` | Update course |
| [/api/Admin/Course/ToggleStatus/{id}](#apiadmincoursetogglestatusid) | `PATCH` | Change visibility |
| [/api/Admin/Course/Delete/{id}](#apiadmincoursedeleteid) | `DELETE` | Remove course |
| [/api/Admin/Course/GetAll](#apiadmincoursegetall) | `GET` | Admin list courses |
| [/api/Admin/Course/GetById/{id}](#apiadmincoursegetbyidid) | `GET` | Admin course details |
| [/api/Admin/Lesson/Create](#apiadminlessoncreate) | `POST` | Create lesson |
| [/api/Admin/Lesson/Update/{id}](#apiadminlessonupdateid) | `PUT` | Update lesson |
| [/api/Admin/Lesson/Delete/{id}](#apiadminlessondeleteid) | `DELETE` | Remove lesson |
| [/api/Admin/Lesson/ToggleStatus/{id}](#apiadminlessontogglestatusid) | `PATCH` | Toggle visibility |
| [/api/Admin/Lesson/GetAll](#apiadminlessongetall) | `GET` | Admin list lessons |
| [/api/Admin/Lesson/GetById/{id}](#apiadminlessongetbyidid) | `GET` | Admin lesson details |
| [/api/Admin/Lesson/GetByCourseId/{courseId}](#apiadminlessongetbycourseidcourseid) | `GET` | Lessons by course |
| [/api/Admin/Quiz/Create](#apiadminquizcreate) | `POST` | Create quiz |
| [/api/Admin/Quiz/Update/{id}](#apiadminquizupdateid) | `PUT` | Update quiz |
| [/api/Admin/Quiz/ToggleStatus/{id}](#apiadminquiztogglestatusid) | `PATCH` | Toggle quiz |
| [/api/Admin/Quiz/Delete/{id}](#apiadminquizdeleteid) | `DELETE` | Remove quiz |
| [/api/Admin/Quiz/GetAll](#apiadminquizgetall) | `GET` | Admin list quizzes |
| [/api/Admin/Quiz/GetById/{id}](#apiadminquizgetbyidid) | `GET` | Admin quiz details |
| [/api/Admin/Quran/surahs](#apiadminquransurahs) | `GET` | Admin Surahs |
| [/api/Admin/Quran/surahs/{number}](#apiadminquransurahsnumber) | `GET` | Admin Surah detail |
| [/api/Admin/Quran/surahs/{surahNumber}/ayahs/{ayahNumber}](#apiadminquransurahssurahnumberayahsayahnumber) | `GET` | Admin Ayah detail |
| [/api/Admin/Quran/search](#apiadminquransearch) | `GET` | Admin search |
| [/api/Admin/Quran/SearchGeneric](#apiadminquransearchgeneric) | `GET` | Admin search generic |
| [/api/Admin/User/GetAllUsers](#apiadminusergetallusers) | `GET` | Manage users |
| [/api/Admin/User/GetUserById/{id}](#apiadminusergetuserbyidid) | `GET` | User details |
| [/api/Admin/User/BlockUser/{userId}](#apiadminuserblockuseruserid) | `PATCH` | Block user |
| [/api/Admin/User/UnBlockUser/{userId}](#apiadminuserunblockuseruserid) | `PATCH` | Unblock user |
| [/api/Admin/User/IsBlockedUser/{userId}](#apiadminuserisblockeduseruserid) | `PATCH` | Check status |
| [/api/Admin/User/ChangeRole/{userId}](#apiadminuserchangeroleuserid) | `PATCH` | Manage roles |
| [/api/Admin/User/GetMyProfile](#apiadminusergetmyprofile) | `GET` | Admin profile |
| [/api/Admin/User/UpdateMyProfile](#apiadminuserupdatemyprofile) | `PUT` | Admin update |
| [/api/Admin/User/ChangePassword](#apiadminuserchangepassword) | `PUT` | Admin security |
| [/api/Admin/User/ChangeEmail](#apiadminuserchangeemail) | `PUT` | Admin email |
| [/api/Admin/User/ConfirmNewEmail](#apiadminuserconfirmnewemail) | `GET` | Admin confirm |
| [/api/Admin/UserProgress/add](#apiadminuserprogressadd) | `POST` | Admin add stats |
| [/api/Admin/UserProgress/me](#apiadminuserprogressme) | `GET` | Admin my stats |
| [/api/Admin/ThikrCategory/GetAudioUrls](#apiadminthikrcategorygetaudiourls) | `GET` | Media check |
| [/api/Admin/ThikrCategory/GetAll](#apiadminthikrcategorygetall) | `GET` | Admin thikr list |
| [/api/Admin/ThikrCategory/GetById/{id}](#apiadminthikrcategorygetbyidid) | `GET` | Admin thikr detail |
| [/api/Admin/ThikrCategory/Search](#apiadminthikrcategorysearch) | `GET` | Admin thikr search |
| [/api/Admin/ThikrCategory/Create](#apiadminthikrcategorycreate) | `POST` | Admin create thikr |
| [/api/Admin/ThikrCategory/Update/{id}](#apiadminthikrcategoryupdateid) | `PUT` | Admin update thikr |
| [/api/Admin/ThikrCategory/Delete/{id}](#apiadminthikrcategorydeleteid) | `DELETE` | Admin remove thikr |
| [/api/Admin/ThikrCategory/ToggleStatus/{id}](#apiadminthikrcategorytogglestatusid) | `PATCH` | Admin visibility |
| [/api/Admin/ThikrItem/GetAll](#apiadminthikritemgetall) | `GET` | Admin items list |
| [/api/Admin/ThikrItem/GetById/{id}](#apiadminthikritemgetbyidid) | `GET` | Admin item detail |
| [/api/Admin/ThikrItem/GetByCategoryId/{categoryId}](#apiadminthikritemgetbycategoryidcategoryid) | `GET` | Admin items by cat |
| [/api/Admin/ThikrItem/Search](#apiadminthikritemsearch) | `GET` | Admin items search |
| [/api/Admin/ThikrItem/GetByCount](#apiadminthikritemgetbycount) | `GET` | Admin items count |
| [/api/Admin/ThikrItem/Create](#apiadminthikritemcreate) | `POST` | Admin create item |
| [/api/Admin/ThikrItem/Update/{id}](#apiadminthikritemupdateid) | `PUT` | Admin update item |
| [/api/Admin/ThikrItem/Delete/{id}](#apiadminthikritemdeleteid) | `DELETE` | Admin remove item |
| [/api/Admin/ThikrItem/ToggleStatus/{id}](#apiadminthikritemtogglestatusid) | `PATCH` | Admin item status |
| [/api/Admin/HadithBooks/GetAll](#apiadminhadithbooksgetall) | `GET` | Admin books list |
| [/api/Admin/HadithBooks/GetById/{id}](#apiadminhadithbooksgetbyidid) | `GET` | Admin book details |
| [/api/Admin/HadithBooks/Search](#apiadminhadithbookssearch) | `GET` | Admin search books |
| [/api/Admin/HadithBooks/{id}/chapters](#apiadminhadithbooksidchapters) | `GET` | Admin book chapters |
| [/api/Admin/HadithBooks/{id}/hadiths](#apiadminhadithbooksidhadiths) | `GET` | Admin book hadiths |
| [/api/Admin/HadithBooks/{id}/random](#apiadminhadithbooksidrandom) | `GET` | Admin book random |
| [/api/Admin/HadithBooks/{id}/stats](#apiadminhadithbooksidstats) | `GET` | Admin book analytics |
| [/api/Admin/HadithBooks/Create](#apiadminhadithbookscreate) | `POST` | Admin create book |
| [/api/Admin/HadithBooks/Update/{id}](#apiadminhadithbooksupdateid) | `PUT` | Admin update book |
| [/api/Admin/HadithBooks/Delete/{id}](#apiadminhadithbooksdeleteid) | `DELETE` | Admin delete book |
| [/api/Admin/HadithBooks/ToggleStatus/{id}](#apiadminhadithbookstogglestatusid) | `PATCH` | Admin book status |
| [/api/Admin/HadithChapters/GetAll](#apiadminhadithchaptersgetall) | `GET` | Admin list chapters |
| [/api/Admin/HadithChapters/GetById/{id}](#apiadminhadithchaptersgetbyidid) | `GET` | Admin chapter details |
| [/api/Admin/HadithChapters/book/{bookId}](#apiadminhadithchaptersbookbookid) | `GET` | Admin chapter by book |
| [/api/Admin/HadithChapters/Search](#apiadminhadithchapterssearch) | `GET` | Admin search chapters |
| [/api/Admin/HadithChapters/{id}/hadiths](#apiadminhadithchaptersidhadiths) | `GET` | Admin chapter hadiths |
| [/api/Admin/HadithChapters/{id}/random](#apiadminhadithchaptersidrandom) | `GET` | Admin chapter random |
| [/api/Admin/HadithChapters/{id}/stats](#apiadminhadithchaptersidstats) | `GET` | Admin chapter stats |
| [/api/Admin/HadithChapters/Create](#apiadminhadithchapterscreate) | `POST` | Admin create chapter |
| [/api/Admin/HadithChapters/Update/{id}](#apiadminhadithchaptersupdateid) | `PUT` | Admin update chapter |
| [/api/Admin/HadithChapters/Delete/{id}](#apiadminhadithchaptersdeleteid) | `DELETE` | Admin delete chapter |
| [/api/Admin/HadithChapters/ToggleStatus/{id}](#apiadminhadithchapterstogglestatusid) | `PATCH` | Admin chapter status |
| [/api/Admin/Hadiths/GetAll](#apiadminhadithsgetall) | `GET` | Admin list hadiths |
| [/api/Admin/Hadiths/GetById/{id}](#apiadminhadithsgetbyidid) | `GET` | Admin hadith details |
| [/api/Admin/Hadiths/chapter/{chapterId}](#apiadminhadithschapterchapterid) | `GET` | Admin hadith by chapter |
| [/api/Admin/Hadiths/book/{bookId}](#apiadminhadithsbookbookid) | `GET` | Admin hadith by book |
| [/api/Admin/Hadiths/Search](#apiadminhadithssearch) | `GET` | Admin search hadiths |
| [/api/Admin/Hadiths/englishNarrator/{name}](#apiadminhadithsenglishnarratorname) | `GET` | Admin narrator filter |
| [/api/Admin/Hadiths/random](#apiadminhadithsrandom) | `GET` | Admin random hadith |
| [/api/Admin/Hadiths/stats](#apiadminhadithsstats) | `GET` | Admin hadith stats |
| [/api/Admin/Hadiths/Create](#apiadminhadithscreate) | `POST` | Admin create hadith |
| [/api/Admin/Hadiths/Update/{id}](#apiadminhadithsupdateid) | `PUT` | Admin update hadith |
| [/api/Admin/Hadiths/Delete/{id}](#apiadminhadithsdeleteid) | `DELETE` | Admin delete hadith |
| [/api/Admin/Hadiths/ToggleStatus/{id}](#apiadminhadithstogglestatusid) | `PATCH` | Admin hadith status |
| [/api/Student/Category/GetAll](#apistudentcategorygetall) | `GET` | Student list categories |
| [/api/Student/Category/GetById/{id}](#apistudentcategorygetbyidid) | `GET` | Student category details |
| [/api/Identity/Authentication/Refresh](#apiidentityauthenticationrefresh) | `POST` | Refresh token |
| [/api/Identity/Authentication/Register](#apiidentityauthenticationregister) | `POST` | User sign-up |
| [/api/Identity/Authentication/Login](#apiidentityauthenticationlogin) | `POST` | User sign-in |
| [/api/Identity/Authentication/Logout](#apiidentityauthenticationlogout) | `POST` | End session |
| [/api/Identity/Authentication/ConfirmEmail](#apiidentityauthenticationconfirmemail) | `GET` | Verify account |
| [/api/Identity/Authentication/ForgotPassword](#apiidentityauthenticationforgotpassword) | `POST` | Reset request |
| [/api/Identity/Authentication/ResetPassword](#apiidentityauthenticationresetpassword) | `POST` | Set new password |
| [/api/Admin/Category/GetAll](#apiadmincategorygetall) | `GET` | Admin categories |
| [/api/Admin/Category/GetById/{id}](#apiadmincategorygetbyidid) | `GET` | Admin category detail |
| [/api/Admin/Category/Create](#apiadmincategorycreate) | `POST` | Admin create category |
| [/api/Admin/Category/Update/{id}](#apiadmincategoryupdateid) | `PATCH` | Admin update category |
| [/api/Admin/Category/ToggleStatus/{id}](#apiadmincategorytogglestatusid) | `PATCH` | Admin category status |
| [/api/Admin/Category/Delete/{id}](#apiadmincategorydeleteid) | `DELETE` | Admin remove category |

<br>

---

<br>


### 📋 Request Models Table of Contents

| Category | Model Name |
| :--- | :--- |
| **Quran** | [AyahRequest](#ayahrequest), [SurahRequest](#surahrequest) |
| **Hadith** | [HadithBookRequest](#hadithbookrequest), [HadithChapterRequest](#hadithchapterrequest), [HadithRequest](#hadithrequest) |
| **Educational** | [CategoryRequest](#categoryrequest), [CourseRequest](#courserequest), [LessonRequest](#lessonrequest) |
| **Quiz** | [QuizRequest](#quizrequest), [QuestionRequest](#questionrequest) |
| **Thikr** | [ThikrCategoryRequest](#thikrcategoryrequest), [ThikrItemRequest](#thikritemrequest) |
| **Authentication** | [RegisterRequest](#registerrequest), [LoginRequest](#loginrequest), [RefreshTokenRequest](#refreshtokenrequest) |
| **Identity Actions** | [ForgotPasswordRequest](#forgotpasswordrequest), [ResetPasswordRequest](#resetpasswordrequest) |
| **User Profile** | [UpdateProfileRequest](#updateprofilerequest), [UserDto](#userdto) |
| **Account Edits** | [ChangeEmailRequest](#changeemailrequest), [ChangePasswordRequest](#changepasswordrequest), [ChangeRoleRequest](#changerolerequest) |
| **User Progress** | [ProgressCreateRequest](#progresscreaterequest), [ProgressUpdateRequest](#progressupdaterequest) |
| **System Types** | [IFormFile](#iformfile), [FilesTypes](#filestypes), [ProgressType](#progresstype) |


<br>

---

<br>

### 📋 Response Models Table of Contents

| Category | Model Name |
| :--- | :--- |
| **Quran** | [AyahResponse](#ayahresponse), [SurahResponse](#surahresponse) |
| **Hadith** | [HadithBookResponse](#hadithbookresponse), [HadithChapterResponse](#hadithchapterresponse), [HadithResponse](#hadithresponse) |
| **Educational** | [CategoryResponse](#categoryresponse), [CourseResponse](#courseresponse), [LessonResponse](#lessonresponse), [FileResponse](#fileresponse) |
| **Quiz** | [QuizResponse](#quizresponse), [QuestionResponse](#questionresponse) |
| **Thikr** | [ThikrCategoryResponse](#thikrcategoryresponse), [ThikrItemResponse](#thikritemresponse) |
| **Identity & Access** | [UserResponse](#userresponse), [UserDTO](#userdto), [RegisterResponse](#registerresponse) |
| **Tracking** | [ProgressResponse](#progressresponse) |

<br>

---

<br>

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


<br>
<br>
<hr>
<hr>
<br>
<br>

### 📦 Request Models (DTOs)

#### AyahRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| surahNumber | integer | | No |
| numberInSurah | integer | | No |
| globalNumber | integer | | No |
| text | string | | No |
| normalizedText | string | | No |
| juz | integer | | No |
| page | integer | | No |
| surahId | integer | | No |

#### SurahRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| id | integer | | No |
| number | integer | | No |
| name | string | | No |
| englishName | string | | No |
| englishNameTranslation | string | | No |
| revelationPlace | string | | No |
| ayahCount | integer | | No |

#### CategoryRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| name | string | | No |
| mainImage | [IFormFile](#iformfile) | | No |

#### CourseRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| title | string | | No |
| description | string | | No |
| categoryId | integer | | No |
| lessonIds | [ integer ] | | No |
| mainImage | [IFormFile](#iformfile) | | No |

#### LessonRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| title | string | | No |
| courseId | integer | | No |
| contentText | string | | No |
| files | [ [IFormFile](#iformfile) ] | | No |
| fileTypes | [ [FilesTypes](#filestypes) ] | | No |

#### HadithBookRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| arabicTitle | string | | No |
| arabicAuthor | string | | No |
| arabicIntroduction | string | | No |
| englishTitle | string | | No |
| englishAuthor | string | | No |
| englishIntroduction | string | | No |

#### HadithChapterRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| arabicTitle | string | | No |
| englishTitle | string | | No |
| hadithBookId | integer | | No |

#### HadithRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| idInBook | integer | | No |
| arabicText | string | | No |
| normalizedText | string | | No |
| englishNarrator | string | | No |
| englishText | string | | No |
| hadithChapterId | integer | | No |
| hadithBookId | integer | | No |

#### QuizRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| title | string | | No |
| lessonId | integer | | No |
| questions | [ [QuestionRequest](#questionrequest) ] | | No |

#### QuestionRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| text | string | | No |
| correctAnswer | string | | No |
| options | [ string ] | | No |

#### ThikrCategoryRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| title | string | | No |
| normalizedText | string | | No |
| audioUrl | string | | No |

#### ThikrItemRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| text | string | | No |
| normalizedText | string | | No |
| count | integer | | No |
| description | string | | No |
| reference | string | | No |
| thikrCategoryId | integer | | No |

#### ProgressCreateRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| type | [ProgressType](#progresstype) | | No |
| relatedItemId | integer | | No |
| count | integer | | No |

#### ProgressUpdateRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| id | integer | | No |
| count | integer | | No |

#### RegisterRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| fullName | string | | No |
| userName | string | | No |
| email | string | | No |
| password | string | | No |
| phoneNumber | string | | No |

#### LoginRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| email | string | | No |
| password | string | | No |

#### RefreshTokenRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| refreshToken | string | | No |

#### ForgotPasswordRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| email | string | | No |

#### ResetPasswordRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| newPassword | string | | No |
| email | string | | No |
| code | string | | No |

#### UpdateProfileRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| fullName | string | | No |
| userName | string | | No |
| phoneNumber | string | | No |
| city | string | | No |
| street | string | | No |

#### ChangeEmailRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| newEmail | string | | No |

#### ChangePasswordRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| currentPassword | string | | No |
| newPassword | string | | No |

#### ChangeRoleRequest
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| roleName | string | | No |

#### UserDto
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| accessToken | string | | No |
| refreshToken | string | | No |

#### IFormFile
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| IFormFile | string | | |

#### FilesTypes
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| FilesTypes | integer | | |

#### ProgressType
| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| ProgressType | | | |





### 📤 Response Models (DTOs)

#### AyahResponse
| Name | Type | Description |
| ---- | ---- | ----------- |
| surahNumber | integer | Number of the surah in the Quran |
| numberInSurah | integer | Ayah number within its surah |
| globalNumber | integer | Global ayah number (1-6236) |
| text | string | Original Arabic text |
| normalizedText | string | Search-optimized Arabic text |
| juz | integer | Juz number |
| page | integer | Page number in the Madani Mushaf |

#### SurahResponse
| Name | Type | Description |
| ---- | ---- | ----------- |
| id | integer | Database identifier |
| number | integer | Surah number (1-114) |
| name | string | Arabic name of the surah |
| englishName | string | Transliterated English name |
| englishNameTranslation | string | English meaning of the name |
| revelationPlace | string | Meccan or Medinan |
| ayahCount | integer | Total number of ayahs |
| ayahs | [ [AyahResponse](#ayahresponse) ] | List of ayahs in the surah |

#### HadithBookResponse
| Name | Type | Description |
| ---- | ---- | ----------- |
| id | integer | Database identifier |
| arabicTitle | string | Arabic title of the book |
| englishTitle | string | English title of the book |
| ChapterCount | integer | Total count of chapters in book |
| HadithCount | integer | Total count of hadiths in book |

#### HadithChapterResponse
| Name | Type | Description |
| ---- | ---- | ----------- |
| id | integer | Database identifier |
| arabicTitle | string | Chapter title in Arabic |
| englishTitle | string | Chapter title in English |
| HadithCount | integer | Total count of hadiths in chapter |

#### HadithResponse
| Name | Type | Description |
| ---- | ---- | ----------- |
| id | integer | Database identifier |
| idInBook | integer | Hadith number within the specific book |
| arabicText | string | Original Arabic text |
| englishText | string | English translation |
| englishNarrator | string | Name of the narrator |
| hadithChapterId | integer | Associated chapter ID |
| hadithBookId | integer | Associated book ID |

#### CategoryResponse
| Name | Type | Description |
| ---- | ---- | ----------- |
| id | integer | Database identifier |
| name | string | Category name |
| mainImageUrl | string | Public URL for the category image |
| CoursesIds | List<int>  | list of courses ids related with the category |

#### CourseResponse
| Name | Type | Description |
| ---- | ---- | ----------- |
| id | integer | Database identifier |
| title | string | Course title |
| description | string | Detailed description |
| categoryId | integer | Parent category identifier |
| mainImageUrl | string | Public URL for the course image |
| LessonsIds | List<int>  | list of lessons ids related with the course |

#### LessonResponse
| Name | Type | Description |
| ---- | ---- | ----------- |
| id | integer | Database identifier |
| title | string | Lesson title |
| contentText | string | Text content of the lesson |
| courseId | integer | Parent course identifier |
| QuizIds | List<int>  | list of quizes ids related with the lesson |
| files | [ [FileResponse](#fileresponse) ] | List of media files (Audio/Video/PDF) |

#### FileResponse
| Name | Type | Description |
| ---- | ---- | ----------- |
| Url | string | Public access URL |
| fileType | [FilesTypes](#filestypes) | Enum indicating text, image, video, audio, or pdf |

#### QuizResponse
| Name | Type | Description |
| ---- | ---- | ----------- |
| id | integer | Database identifier |
| title | string | Quiz title |
| lessonId | integer | Associated lesson identifier |
| QuestionsIds | List<int>  | list of questions ids related with the quiz |
| questions | [ [QuestionResponse](#questionreponse) ] | List of quiz questions |

#### QuestionResponse
| Name | Type | Description |
| ---- | ---- | ----------- |
| id | integer | Database identifier |
| text | string | The question text |
| options | Lisr< string> | List of multiple-choice options |

#### ThikrCategoryResponse
| Name | Type | Description |
| ---- | ---- | ----------- |
| id | integer | Database identifier |
| title | string | Thikr group title |
| audioUrl | string | URL for category-wide audio |
| ThikrItemsIds | List<int>  | list of items ids related with the category |
| thikrItems | [ [ThikrItemResponse](#thikritemresponse) ] | List of thikr items |

#### ThikrItemResponse
| Name | Type | Description |
| ---- | ---- | ----------- |
| id | integer | Database identifier |
| text | string | Arabic thikr text |
| description | string | Meaning or virtue |
| count | integer | Required repetition count |
| ThikrCategoryId | integer | Associated ThikrCategory identifier |
| reference | string | Source (e.g., Sahih Muslim) |

#### UserResponse
| Name | Type | Description |
| ---- | ---- | ----------- |
| id | string | Unique user identifier |
| fullName | string | User's full name |
| email | string | Registered email |
| userName | string | Chosen username |
| phoneNumber | string | Contact number |
| roleName | string | User permission level |
     public bool EmailConfirmed { get; set; }
     public string? City { get; set; }
public string? Street { get; set; }
public List<UserProgressResponse> UserProgresses { get; set; }

#### UserDTO
| Name | Type | Description |
| ---- | ---- | ----------- |
| AccessToken | string | Access token feild|
| RefreshToken | string | Refresh token feild |

#### RegisterResponse
| Name | Type | Description |
| ---- | ---- | ----------- |
| message | string | Success or failure message |
| email | string | Registered email |

#### ProgressResponse
| Name | Type | Description |
| ---- | ---- | ----------- |
| id | integer | Progress record identifier |
| type | [ProgressType](#progresstype) | Type (Course, Lesson, etc.) |
| relatedItemId | integer | ID of the item being tracked |
| count | integer | Current completion count or score |
| LastUpdated | DateTime | Date of last update |
