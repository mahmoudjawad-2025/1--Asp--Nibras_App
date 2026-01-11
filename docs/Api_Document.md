---
title: PL | v1 v1.0.0
language_tabs:
  - "false": "false"
language_clients:
  - "false": ""
toc_footers: []
includes: []
search: false
highlight_theme: darkula
headingLevel: 2

---

<!-- Generator: Widdershins v4.0.1 -->

<h1 id="pl-v1">PL | v1 v1.0.0</h1>

> Scroll down for code samples, example requests and responses. Select a language for code samples from the tabs above or the mobile navigation menu.

Base URLs:

* <a href="https://localhost:7050">https://localhost:7050</a>

* <a href="http://localhost:5160">http://localhost:5160</a>

<h1 id="pl-v1-course">Course</h1>

## get__api_Student_Course_GetAll

> Code samples

`GET /api/Student/Course/GetAll`

<h3 id="get__api_student_course_getall-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_Course_GetById_{id}

> Code samples

`GET /api/Student/Course/GetById/{id}`

<h3 id="get__api_student_course_getbyid_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_student_course_getbyid_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Admin_Course_Create

> Code samples

`POST /api/Admin/Course/Create`

> Body parameter

```yaml
Title: string
Description: string
CategoryId: 0
LessonIds:
  - 0
MainImage: string

```

<h3 id="post__api_admin_course_create-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|object|true|none|
|» Title|body|string|false|none|
|» Description|body|string|false|none|
|» CategoryId|body|integer(int32)|false|none|
|» LessonIds|body|[integer]|false|none|
|» MainImage|body|[IFormFile](#schemaiformfile)(binary)|false|none|

<h3 id="post__api_admin_course_create-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## put__api_Admin_Course_Update_{id}

> Code samples

`PUT /api/Admin/Course/Update/{id}`

> Body parameter

```yaml
Title: string
Description: string
CategoryId: 0
LessonIds:
  - 0
MainImage: string

```

<h3 id="put__api_admin_course_update_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|object|true|none|
|» Title|body|string|false|none|
|» Description|body|string|false|none|
|» CategoryId|body|integer(int32)|false|none|
|» LessonIds|body|[integer]|false|none|
|» MainImage|body|[IFormFile](#schemaiformfile)(binary)|false|none|

<h3 id="put__api_admin_course_update_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_Admin_Course_ToggleStatus_{id}

> Code samples

`PATCH /api/Admin/Course/ToggleStatus/{id}`

<h3 id="patch__api_admin_course_togglestatus_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="patch__api_admin_course_togglestatus_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## delete__api_Admin_Course_Delete_{id}

> Code samples

`DELETE /api/Admin/Course/Delete/{id}`

<h3 id="delete__api_admin_course_delete_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="delete__api_admin_course_delete_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Course_GetAll

> Code samples

`GET /api/Admin/Course/GetAll`

<h3 id="get__api_admin_course_getall-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Course_GetById_{id}

> Code samples

`GET /api/Admin/Course/GetById/{id}`

<h3 id="get__api_admin_course_getbyid_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_admin_course_getbyid_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-lesson">Lesson</h1>

## get__api_Student_Lesson_GetAll

> Code samples

`GET /api/Student/Lesson/GetAll`

<h3 id="get__api_student_lesson_getall-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_Lesson_GetById_{id}

> Code samples

`GET /api/Student/Lesson/GetById/{id}`

<h3 id="get__api_student_lesson_getbyid_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_student_lesson_getbyid_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_Lesson_GetByCourseId_{courseId}

> Code samples

`GET /api/Student/Lesson/GetByCourseId/{courseId}`

<h3 id="get__api_student_lesson_getbycourseid_{courseid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|courseId|path|integer(int32)|true|none|

<h3 id="get__api_student_lesson_getbycourseid_{courseid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Admin_Lesson_Create

> Code samples

`POST /api/Admin/Lesson/Create`

> Body parameter

```yaml
Title: string
CourseId: 0
ContentText: string
Files:
  - string
FileTypes:
  - 0

```

<h3 id="post__api_admin_lesson_create-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|object|true|none|
|» Title|body|string|false|none|
|» CourseId|body|integer(int32)|false|none|
|» ContentText|body|string|false|none|
|» Files|body|[[IFormFile](#schemaiformfile)]|false|none|
|» FileTypes|body|[[FilesTypes](#schemafilestypes)]|false|none|

<h3 id="post__api_admin_lesson_create-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## put__api_Admin_Lesson_Update_{id}

> Code samples

`PUT /api/Admin/Lesson/Update/{id}`

> Body parameter

```yaml
Title: string
CourseId: 0
ContentText: string
Files:
  - string
FileTypes:
  - 0

```

<h3 id="put__api_admin_lesson_update_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|object|true|none|
|» Title|body|string|false|none|
|» CourseId|body|integer(int32)|false|none|
|» ContentText|body|string|false|none|
|» Files|body|[[IFormFile](#schemaiformfile)]|false|none|
|» FileTypes|body|[[FilesTypes](#schemafilestypes)]|false|none|

<h3 id="put__api_admin_lesson_update_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## delete__api_Admin_Lesson_Delete_{id}

> Code samples

`DELETE /api/Admin/Lesson/Delete/{id}`

<h3 id="delete__api_admin_lesson_delete_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="delete__api_admin_lesson_delete_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_Admin_Lesson_ToggleStatus_{id}

> Code samples

`PATCH /api/Admin/Lesson/ToggleStatus/{id}`

<h3 id="patch__api_admin_lesson_togglestatus_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="patch__api_admin_lesson_togglestatus_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Lesson_GetAll

> Code samples

`GET /api/Admin/Lesson/GetAll`

<h3 id="get__api_admin_lesson_getall-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Lesson_GetById_{id}

> Code samples

`GET /api/Admin/Lesson/GetById/{id}`

<h3 id="get__api_admin_lesson_getbyid_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_admin_lesson_getbyid_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Lesson_GetByCourseId_{courseId}

> Code samples

`GET /api/Admin/Lesson/GetByCourseId/{courseId}`

<h3 id="get__api_admin_lesson_getbycourseid_{courseid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|courseId|path|integer(int32)|true|none|

<h3 id="get__api_admin_lesson_getbycourseid_{courseid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-quiz">Quiz</h1>

## get__api_Student_Quiz_GetAll

> Code samples

`GET /api/Student/Quiz/GetAll`

<h3 id="get__api_student_quiz_getall-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_Quiz_GetById_{id}

> Code samples

`GET /api/Student/Quiz/GetById/{id}`

<h3 id="get__api_student_quiz_getbyid_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_student_quiz_getbyid_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Admin_Quiz_Create

> Code samples

`POST /api/Admin/Quiz/Create`

> Body parameter

```json
{
  "title": "string",
  "lessonId": 0,
  "questions": [
    {
      "text": "string",
      "correctAnswer": "string",
      "options": [
        "string"
      ]
    }
  ]
}
```

<h3 id="post__api_admin_quiz_create-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[QuizRequest](#schemaquizrequest)|true|none|

<h3 id="post__api_admin_quiz_create-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## put__api_Admin_Quiz_Update_{id}

> Code samples

`PUT /api/Admin/Quiz/Update/{id}`

> Body parameter

```json
{
  "title": "string",
  "lessonId": 0,
  "questions": [
    {
      "text": "string",
      "correctAnswer": "string",
      "options": [
        "string"
      ]
    }
  ]
}
```

<h3 id="put__api_admin_quiz_update_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|[QuizRequest](#schemaquizrequest)|true|none|

<h3 id="put__api_admin_quiz_update_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_Admin_Quiz_ToggleStatus_{id}

> Code samples

`PATCH /api/Admin/Quiz/ToggleStatus/{id}`

<h3 id="patch__api_admin_quiz_togglestatus_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="patch__api_admin_quiz_togglestatus_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## delete__api_Admin_Quiz_Delete_{id}

> Code samples

`DELETE /api/Admin/Quiz/Delete/{id}`

<h3 id="delete__api_admin_quiz_delete_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="delete__api_admin_quiz_delete_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Quiz_GetAll

> Code samples

`GET /api/Admin/Quiz/GetAll`

<h3 id="get__api_admin_quiz_getall-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Quiz_GetById_{id}

> Code samples

`GET /api/Admin/Quiz/GetById/{id}`

<h3 id="get__api_admin_quiz_getbyid_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_admin_quiz_getbyid_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-quran">Quran</h1>

## get__api_Student_Quran_surahs

> Code samples

`GET /api/Student/Quran/surahs`

<h3 id="get__api_student_quran_surahs-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_Quran_surahs_{number}

> Code samples

`GET /api/Student/Quran/surahs/{number}`

<h3 id="get__api_student_quran_surahs_{number}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|number|path|integer(int32)|true|none|

<h3 id="get__api_student_quran_surahs_{number}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_Quran_surahs_{surahNumber}_ayahs_{ayahNumber}

> Code samples

`GET /api/Student/Quran/surahs/{surahNumber}/ayahs/{ayahNumber}`

<h3 id="get__api_student_quran_surahs_{surahnumber}_ayahs_{ayahnumber}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|surahNumber|path|integer(int32)|true|none|
|ayahNumber|path|integer(int32)|true|none|

<h3 id="get__api_student_quran_surahs_{surahnumber}_ayahs_{ayahnumber}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_Quran_search

> Code samples

`GET /api/Student/Quran/search`

<h3 id="get__api_student_quran_search-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|q|query|string|false|none|
|limit|query|integer(int32)|false|none|

<h3 id="get__api_student_quran_search-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_Quran_SearchGeneric

> Code samples

`GET /api/Student/Quran/SearchGeneric`

<h3 id="get__api_student_quran_searchgeneric-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|query|query|string|false|none|

<h3 id="get__api_student_quran_searchgeneric-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Quran_surahs

> Code samples

`GET /api/Admin/Quran/surahs`

<h3 id="get__api_admin_quran_surahs-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Quran_surahs_{number}

> Code samples

`GET /api/Admin/Quran/surahs/{number}`

<h3 id="get__api_admin_quran_surahs_{number}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|number|path|integer(int32)|true|none|

<h3 id="get__api_admin_quran_surahs_{number}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Quran_surahs_{surahNumber}_ayahs_{ayahNumber}

> Code samples

`GET /api/Admin/Quran/surahs/{surahNumber}/ayahs/{ayahNumber}`

<h3 id="get__api_admin_quran_surahs_{surahnumber}_ayahs_{ayahnumber}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|surahNumber|path|integer(int32)|true|none|
|ayahNumber|path|integer(int32)|true|none|

<h3 id="get__api_admin_quran_surahs_{surahnumber}_ayahs_{ayahnumber}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Quran_search

> Code samples

`GET /api/Admin/Quran/search`

<h3 id="get__api_admin_quran_search-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|q|query|string|false|none|
|limit|query|integer(int32)|false|none|

<h3 id="get__api_admin_quran_search-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Quran_SearchGeneric

> Code samples

`GET /api/Admin/Quran/SearchGeneric`

<h3 id="get__api_admin_quran_searchgeneric-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|query|query|string|false|none|

<h3 id="get__api_admin_quran_searchgeneric-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-user">User</h1>

## get__api_Student_User_GetMyProfile

> Code samples

`GET /api/Student/User/GetMyProfile`

<h3 id="get__api_student_user_getmyprofile-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## put__api_Student_User_UpdateMyProfile

> Code samples

`PUT /api/Student/User/UpdateMyProfile`

> Body parameter

```json
{
  "fullName": "string",
  "userName": "string",
  "phoneNumber": "string",
  "city": "string",
  "street": "string"
}
```

<h3 id="put__api_student_user_updatemyprofile-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[UpdateProfileRequest](#schemaupdateprofilerequest)|true|none|

<h3 id="put__api_student_user_updatemyprofile-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## put__api_Student_User_ChangePassword

> Code samples

`PUT /api/Student/User/ChangePassword`

> Body parameter

```json
{
  "currentPassword": "string",
  "newPassword": "string"
}
```

<h3 id="put__api_student_user_changepassword-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[ChangePasswordRequest](#schemachangepasswordrequest)|true|none|

<h3 id="put__api_student_user_changepassword-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## put__api_Student_User_ChangeEmail

> Code samples

`PUT /api/Student/User/ChangeEmail`

> Body parameter

```json
{
  "newEmail": "string"
}
```

<h3 id="put__api_student_user_changeemail-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[ChangeEmailRequest](#schemachangeemailrequest)|true|none|

<h3 id="put__api_student_user_changeemail-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_User_ConfirmNewEmail

> Code samples

`GET /api/Student/User/ConfirmNewEmail`

<h3 id="get__api_student_user_confirmnewemail-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|userId|query|string|false|none|
|token|query|string|false|none|
|newEmail|query|string|false|none|

<h3 id="get__api_student_user_confirmnewemail-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_User_GetAllUsers

> Code samples

`GET /api/Admin/User/GetAllUsers`

<h3 id="get__api_admin_user_getallusers-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_User_GetUserById_{id}

> Code samples

`GET /api/Admin/User/GetUserById/{id}`

<h3 id="get__api_admin_user_getuserbyid_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|string|true|none|

<h3 id="get__api_admin_user_getuserbyid_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_Admin_User_BlockUser_{userId}

> Code samples

`PATCH /api/Admin/User/BlockUser/{userId}`

> Body parameter

```json
0
```

<h3 id="patch__api_admin_user_blockuser_{userid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|userId|path|string|true|none|
|body|body|integer(int32)|true|none|

<h3 id="patch__api_admin_user_blockuser_{userid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_Admin_User_UnBlockUser_{userId}

> Code samples

`PATCH /api/Admin/User/UnBlockUser/{userId}`

<h3 id="patch__api_admin_user_unblockuser_{userid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|userId|path|string|true|none|

<h3 id="patch__api_admin_user_unblockuser_{userid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_Admin_User_IsBlockedUser_{userId}

> Code samples

`PATCH /api/Admin/User/IsBlockedUser/{userId}`

<h3 id="patch__api_admin_user_isblockeduser_{userid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|userId|path|string|true|none|

<h3 id="patch__api_admin_user_isblockeduser_{userid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_Admin_User_ChangeRole_{userId}

> Code samples

`PATCH /api/Admin/User/ChangeRole/{userId}`

> Body parameter

```json
{
  "roleName": "string"
}
```

<h3 id="patch__api_admin_user_changerole_{userid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|userId|path|string|true|none|
|body|body|[ChangeRoleRequest](#schemachangerolerequest)|true|none|

<h3 id="patch__api_admin_user_changerole_{userid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_User_GetMyProfile

> Code samples

`GET /api/Admin/User/GetMyProfile`

<h3 id="get__api_admin_user_getmyprofile-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## put__api_Admin_User_UpdateMyProfile

> Code samples

`PUT /api/Admin/User/UpdateMyProfile`

> Body parameter

```json
{
  "fullName": "string",
  "userName": "string",
  "phoneNumber": "string",
  "city": "string",
  "street": "string"
}
```

<h3 id="put__api_admin_user_updatemyprofile-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[UpdateProfileRequest](#schemaupdateprofilerequest)|true|none|

<h3 id="put__api_admin_user_updatemyprofile-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## put__api_Admin_User_ChangePassword

> Code samples

`PUT /api/Admin/User/ChangePassword`

> Body parameter

```json
{
  "currentPassword": "string",
  "newPassword": "string"
}
```

<h3 id="put__api_admin_user_changepassword-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[ChangePasswordRequest](#schemachangepasswordrequest)|true|none|

<h3 id="put__api_admin_user_changepassword-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## put__api_Admin_User_ChangeEmail

> Code samples

`PUT /api/Admin/User/ChangeEmail`

> Body parameter

```json
{
  "newEmail": "string"
}
```

<h3 id="put__api_admin_user_changeemail-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[ChangeEmailRequest](#schemachangeemailrequest)|true|none|

<h3 id="put__api_admin_user_changeemail-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_User_ConfirmNewEmail

> Code samples

`GET /api/Admin/User/ConfirmNewEmail`

<h3 id="get__api_admin_user_confirmnewemail-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|userId|query|string|false|none|
|token|query|string|false|none|
|newEmail|query|string|false|none|

<h3 id="get__api_admin_user_confirmnewemail-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-userprogress">UserProgress</h1>

## post__api_Student_UserProgress_add

> Code samples

`POST /api/Student/UserProgress/add`

> Body parameter

```json
{
  "type": "Thikr",
  "relatedItemId": 0,
  "count": 0
}
```

<h3 id="post__api_student_userprogress_add-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[ProgressCreateRequest](#schemaprogresscreaterequest)|true|none|

<h3 id="post__api_student_userprogress_add-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_UserProgress_me

> Code samples

`GET /api/Student/UserProgress/me`

<h3 id="get__api_student_userprogress_me-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Admin_UserProgress_add

> Code samples

`POST /api/Admin/UserProgress/add`

> Body parameter

```json
{
  "type": "Thikr",
  "relatedItemId": 0,
  "count": 0
}
```

<h3 id="post__api_admin_userprogress_add-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[ProgressCreateRequest](#schemaprogresscreaterequest)|true|none|

<h3 id="post__api_admin_userprogress_add-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_UserProgress_me

> Code samples

`GET /api/Admin/UserProgress/me`

<h3 id="get__api_admin_userprogress_me-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-thikrcategory">ThikrCategory</h1>

## get__api_Student_ThikrCategory_GetAll

> Code samples

`GET /api/Student/ThikrCategory/GetAll`

<h3 id="get__api_student_thikrcategory_getall-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_ThikrCategory_GetById_{id}

> Code samples

`GET /api/Student/ThikrCategory/GetById/{id}`

<h3 id="get__api_student_thikrcategory_getbyid_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_student_thikrcategory_getbyid_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_ThikrCategory_Search

> Code samples

`GET /api/Student/ThikrCategory/Search`

<h3 id="get__api_student_thikrcategory_search-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|query|query|string|false|none|

<h3 id="get__api_student_thikrcategory_search-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_ThikrCategory_GetAudioUrls

> Code samples

`GET /api/Admin/ThikrCategory/GetAudioUrls`

<h3 id="get__api_admin_thikrcategory_getaudiourls-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_ThikrCategory_GetAll

> Code samples

`GET /api/Admin/ThikrCategory/GetAll`

<h3 id="get__api_admin_thikrcategory_getall-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_ThikrCategory_GetById_{id}

> Code samples

`GET /api/Admin/ThikrCategory/GetById/{id}`

<h3 id="get__api_admin_thikrcategory_getbyid_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_admin_thikrcategory_getbyid_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_ThikrCategory_Search

> Code samples

`GET /api/Admin/ThikrCategory/Search`

<h3 id="get__api_admin_thikrcategory_search-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|query|query|string|false|none|

<h3 id="get__api_admin_thikrcategory_search-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Admin_ThikrCategory_Create

> Code samples

`POST /api/Admin/ThikrCategory/Create`

> Body parameter

```json
{
  "title": "string",
  "normalizedText": "string",
  "audioUrl": "string"
}
```

<h3 id="post__api_admin_thikrcategory_create-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[ThikrCategoryRequest](#schemathikrcategoryrequest)|true|none|

<h3 id="post__api_admin_thikrcategory_create-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## put__api_Admin_ThikrCategory_Update_{id}

> Code samples

`PUT /api/Admin/ThikrCategory/Update/{id}`

> Body parameter

```json
{
  "title": "string",
  "normalizedText": "string",
  "audioUrl": "string"
}
```

<h3 id="put__api_admin_thikrcategory_update_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|[ThikrCategoryRequest](#schemathikrcategoryrequest)|true|none|

<h3 id="put__api_admin_thikrcategory_update_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## delete__api_Admin_ThikrCategory_Delete_{id}

> Code samples

`DELETE /api/Admin/ThikrCategory/Delete/{id}`

<h3 id="delete__api_admin_thikrcategory_delete_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="delete__api_admin_thikrcategory_delete_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_Admin_ThikrCategory_ToggleStatus_{id}

> Code samples

`PATCH /api/Admin/ThikrCategory/ToggleStatus/{id}`

<h3 id="patch__api_admin_thikrcategory_togglestatus_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="patch__api_admin_thikrcategory_togglestatus_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-thikritem">ThikrItem</h1>

## get__api_Student_ThikrItem_GetAll

> Code samples

`GET /api/Student/ThikrItem/GetAll`

<h3 id="get__api_student_thikritem_getall-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_ThikrItem_GetById_{id}

> Code samples

`GET /api/Student/ThikrItem/GetById/{id}`

<h3 id="get__api_student_thikritem_getbyid_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_student_thikritem_getbyid_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_ThikrItem_GetByCategoryId_{categoryId}

> Code samples

`GET /api/Student/ThikrItem/GetByCategoryId/{categoryId}`

<h3 id="get__api_student_thikritem_getbycategoryid_{categoryid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|categoryId|path|integer(int32)|true|none|

<h3 id="get__api_student_thikritem_getbycategoryid_{categoryid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_ThikrItem_Search

> Code samples

`GET /api/Student/ThikrItem/Search`

<h3 id="get__api_student_thikritem_search-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|query|query|string|false|none|

<h3 id="get__api_student_thikritem_search-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_ThikrItem_GetByCount

> Code samples

`GET /api/Student/ThikrItem/GetByCount`

<h3 id="get__api_student_thikritem_getbycount-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|minCount|query|integer(int32)|false|none|
|maxCount|query|integer(int32)|false|none|

<h3 id="get__api_student_thikritem_getbycount-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_ThikrItem_GetAll

> Code samples

`GET /api/Admin/ThikrItem/GetAll`

<h3 id="get__api_admin_thikritem_getall-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_ThikrItem_GetById_{id}

> Code samples

`GET /api/Admin/ThikrItem/GetById/{id}`

<h3 id="get__api_admin_thikritem_getbyid_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_admin_thikritem_getbyid_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_ThikrItem_GetByCategoryId_{categoryId}

> Code samples

`GET /api/Admin/ThikrItem/GetByCategoryId/{categoryId}`

<h3 id="get__api_admin_thikritem_getbycategoryid_{categoryid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|categoryId|path|integer(int32)|true|none|

<h3 id="get__api_admin_thikritem_getbycategoryid_{categoryid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_ThikrItem_Search

> Code samples

`GET /api/Admin/ThikrItem/Search`

<h3 id="get__api_admin_thikritem_search-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|query|query|string|false|none|

<h3 id="get__api_admin_thikritem_search-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_ThikrItem_GetByCount

> Code samples

`GET /api/Admin/ThikrItem/GetByCount`

<h3 id="get__api_admin_thikritem_getbycount-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|minCount|query|integer(int32)|false|none|
|maxCount|query|integer(int32)|false|none|

<h3 id="get__api_admin_thikritem_getbycount-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Admin_ThikrItem_Create

> Code samples

`POST /api/Admin/ThikrItem/Create`

> Body parameter

```json
{
  "text": "string",
  "normalizedText": "string",
  "count": 0,
  "description": "string",
  "reference": "string",
  "thikrCategoryId": 0
}
```

<h3 id="post__api_admin_thikritem_create-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[ThikrItemRequest](#schemathikritemrequest)|true|none|

<h3 id="post__api_admin_thikritem_create-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## put__api_Admin_ThikrItem_Update_{id}

> Code samples

`PUT /api/Admin/ThikrItem/Update/{id}`

> Body parameter

```json
{
  "text": "string",
  "normalizedText": "string",
  "count": 0,
  "description": "string",
  "reference": "string",
  "thikrCategoryId": 0
}
```

<h3 id="put__api_admin_thikritem_update_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|[ThikrItemRequest](#schemathikritemrequest)|true|none|

<h3 id="put__api_admin_thikritem_update_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## delete__api_Admin_ThikrItem_Delete_{id}

> Code samples

`DELETE /api/Admin/ThikrItem/Delete/{id}`

<h3 id="delete__api_admin_thikritem_delete_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="delete__api_admin_thikritem_delete_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_Admin_ThikrItem_ToggleStatus_{id}

> Code samples

`PATCH /api/Admin/ThikrItem/ToggleStatus/{id}`

<h3 id="patch__api_admin_thikritem_togglestatus_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="patch__api_admin_thikritem_togglestatus_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-hadithbooks">HadithBooks</h1>

## get__api_Student_HadithBooks_GetAll

> Code samples

`GET /api/Student/HadithBooks/GetAll`

<h3 id="get__api_student_hadithbooks_getall-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_HadithBooks_GetById_{id}

> Code samples

`GET /api/Student/HadithBooks/GetById/{id}`

<h3 id="get__api_student_hadithbooks_getbyid_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_student_hadithbooks_getbyid_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_HadithBooks_Search

> Code samples

`GET /api/Student/HadithBooks/Search`

<h3 id="get__api_student_hadithbooks_search-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|query|query|string|false|none|

<h3 id="get__api_student_hadithbooks_search-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_HadithBooks_{id}_chapters

> Code samples

`GET /api/Student/HadithBooks/{id}/chapters`

<h3 id="get__api_student_hadithbooks_{id}_chapters-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_student_hadithbooks_{id}_chapters-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_HadithBooks_{id}_hadiths

> Code samples

`GET /api/Student/HadithBooks/{id}/hadiths`

<h3 id="get__api_student_hadithbooks_{id}_hadiths-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_student_hadithbooks_{id}_hadiths-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_HadithBooks_{id}_random

> Code samples

`GET /api/Student/HadithBooks/{id}/random`

<h3 id="get__api_student_hadithbooks_{id}_random-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_student_hadithbooks_{id}_random-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_HadithBooks_{id}_stats

> Code samples

`GET /api/Student/HadithBooks/{id}/stats`

<h3 id="get__api_student_hadithbooks_{id}_stats-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_student_hadithbooks_{id}_stats-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_HadithBooks_GetAll

> Code samples

`GET /api/Admin/HadithBooks/GetAll`

<h3 id="get__api_admin_hadithbooks_getall-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_HadithBooks_GetById_{id}

> Code samples

`GET /api/Admin/HadithBooks/GetById/{id}`

<h3 id="get__api_admin_hadithbooks_getbyid_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_admin_hadithbooks_getbyid_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_HadithBooks_Search

> Code samples

`GET /api/Admin/HadithBooks/Search`

<h3 id="get__api_admin_hadithbooks_search-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|query|query|string|false|none|

<h3 id="get__api_admin_hadithbooks_search-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_HadithBooks_{id}_chapters

> Code samples

`GET /api/Admin/HadithBooks/{id}/chapters`

<h3 id="get__api_admin_hadithbooks_{id}_chapters-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_admin_hadithbooks_{id}_chapters-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_HadithBooks_{id}_hadiths

> Code samples

`GET /api/Admin/HadithBooks/{id}/hadiths`

<h3 id="get__api_admin_hadithbooks_{id}_hadiths-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_admin_hadithbooks_{id}_hadiths-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_HadithBooks_{id}_random

> Code samples

`GET /api/Admin/HadithBooks/{id}/random`

<h3 id="get__api_admin_hadithbooks_{id}_random-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_admin_hadithbooks_{id}_random-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_HadithBooks_{id}_stats

> Code samples

`GET /api/Admin/HadithBooks/{id}/stats`

<h3 id="get__api_admin_hadithbooks_{id}_stats-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_admin_hadithbooks_{id}_stats-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Admin_HadithBooks_Create

> Code samples

`POST /api/Admin/HadithBooks/Create`

> Body parameter

```json
{
  "arabicTitle": "string",
  "arabicAuthor": "string",
  "arabicIntroduction": "string",
  "englishTitle": "string",
  "englishAuthor": "string",
  "englishIntroduction": "string"
}
```

<h3 id="post__api_admin_hadithbooks_create-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[HadithBookRequest](#schemahadithbookrequest)|true|none|

<h3 id="post__api_admin_hadithbooks_create-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## put__api_Admin_HadithBooks_Update_{id}

> Code samples

`PUT /api/Admin/HadithBooks/Update/{id}`

> Body parameter

```json
{
  "arabicTitle": "string",
  "arabicAuthor": "string",
  "arabicIntroduction": "string",
  "englishTitle": "string",
  "englishAuthor": "string",
  "englishIntroduction": "string"
}
```

<h3 id="put__api_admin_hadithbooks_update_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|[HadithBookRequest](#schemahadithbookrequest)|true|none|

<h3 id="put__api_admin_hadithbooks_update_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## delete__api_Admin_HadithBooks_Delete_{id}

> Code samples

`DELETE /api/Admin/HadithBooks/Delete/{id}`

<h3 id="delete__api_admin_hadithbooks_delete_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="delete__api_admin_hadithbooks_delete_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_Admin_HadithBooks_ToggleStatus_{id}

> Code samples

`PATCH /api/Admin/HadithBooks/ToggleStatus/{id}`

<h3 id="patch__api_admin_hadithbooks_togglestatus_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="patch__api_admin_hadithbooks_togglestatus_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-hadithchapters">HadithChapters</h1>

## get__api_Student_HadithChapters_GetAll

> Code samples

`GET /api/Student/HadithChapters/GetAll`

<h3 id="get__api_student_hadithchapters_getall-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_HadithChapters_GetById_{id}

> Code samples

`GET /api/Student/HadithChapters/GetById/{id}`

<h3 id="get__api_student_hadithchapters_getbyid_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_student_hadithchapters_getbyid_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_HadithChapters_book_{bookId}

> Code samples

`GET /api/Student/HadithChapters/book/{bookId}`

<h3 id="get__api_student_hadithchapters_book_{bookid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|bookId|path|integer(int32)|true|none|

<h3 id="get__api_student_hadithchapters_book_{bookid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_HadithChapters_Search

> Code samples

`GET /api/Student/HadithChapters/Search`

<h3 id="get__api_student_hadithchapters_search-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|query|query|string|false|none|

<h3 id="get__api_student_hadithchapters_search-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_HadithChapters_{id}_hadiths

> Code samples

`GET /api/Student/HadithChapters/{id}/hadiths`

<h3 id="get__api_student_hadithchapters_{id}_hadiths-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_student_hadithchapters_{id}_hadiths-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_HadithChapters_{id}_random

> Code samples

`GET /api/Student/HadithChapters/{id}/random`

<h3 id="get__api_student_hadithchapters_{id}_random-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_student_hadithchapters_{id}_random-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_HadithChapters_{id}_stats

> Code samples

`GET /api/Student/HadithChapters/{id}/stats`

<h3 id="get__api_student_hadithchapters_{id}_stats-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_student_hadithchapters_{id}_stats-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_HadithChapters_GetAll

> Code samples

`GET /api/Admin/HadithChapters/GetAll`

<h3 id="get__api_admin_hadithchapters_getall-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_HadithChapters_GetById_{id}

> Code samples

`GET /api/Admin/HadithChapters/GetById/{id}`

<h3 id="get__api_admin_hadithchapters_getbyid_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_admin_hadithchapters_getbyid_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_HadithChapters_book_{bookId}

> Code samples

`GET /api/Admin/HadithChapters/book/{bookId}`

<h3 id="get__api_admin_hadithchapters_book_{bookid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|bookId|path|integer(int32)|true|none|

<h3 id="get__api_admin_hadithchapters_book_{bookid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_HadithChapters_Search

> Code samples

`GET /api/Admin/HadithChapters/Search`

<h3 id="get__api_admin_hadithchapters_search-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|query|query|string|false|none|

<h3 id="get__api_admin_hadithchapters_search-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_HadithChapters_{id}_hadiths

> Code samples

`GET /api/Admin/HadithChapters/{id}/hadiths`

<h3 id="get__api_admin_hadithchapters_{id}_hadiths-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_admin_hadithchapters_{id}_hadiths-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_HadithChapters_{id}_random

> Code samples

`GET /api/Admin/HadithChapters/{id}/random`

<h3 id="get__api_admin_hadithchapters_{id}_random-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_admin_hadithchapters_{id}_random-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_HadithChapters_{id}_stats

> Code samples

`GET /api/Admin/HadithChapters/{id}/stats`

<h3 id="get__api_admin_hadithchapters_{id}_stats-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_admin_hadithchapters_{id}_stats-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Admin_HadithChapters_Create

> Code samples

`POST /api/Admin/HadithChapters/Create`

> Body parameter

```json
{
  "arabicTitle": "string",
  "englishTitle": "string",
  "hadithBookId": 0
}
```

<h3 id="post__api_admin_hadithchapters_create-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[HadithChapterRequest](#schemahadithchapterrequest)|true|none|

<h3 id="post__api_admin_hadithchapters_create-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## put__api_Admin_HadithChapters_Update_{id}

> Code samples

`PUT /api/Admin/HadithChapters/Update/{id}`

> Body parameter

```json
{
  "arabicTitle": "string",
  "englishTitle": "string",
  "hadithBookId": 0
}
```

<h3 id="put__api_admin_hadithchapters_update_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|[HadithChapterRequest](#schemahadithchapterrequest)|true|none|

<h3 id="put__api_admin_hadithchapters_update_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## delete__api_Admin_HadithChapters_Delete_{id}

> Code samples

`DELETE /api/Admin/HadithChapters/Delete/{id}`

<h3 id="delete__api_admin_hadithchapters_delete_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="delete__api_admin_hadithchapters_delete_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_Admin_HadithChapters_ToggleStatus_{id}

> Code samples

`PATCH /api/Admin/HadithChapters/ToggleStatus/{id}`

<h3 id="patch__api_admin_hadithchapters_togglestatus_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="patch__api_admin_hadithchapters_togglestatus_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-hadiths">Hadiths</h1>

## get__api_Student_Hadiths_GetAll

> Code samples

`GET /api/Student/Hadiths/GetAll`

<h3 id="get__api_student_hadiths_getall-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_Hadiths_GetById_{id}

> Code samples

`GET /api/Student/Hadiths/GetById/{id}`

<h3 id="get__api_student_hadiths_getbyid_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_student_hadiths_getbyid_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_Hadiths_chapter_{chapterId}

> Code samples

`GET /api/Student/Hadiths/chapter/{chapterId}`

<h3 id="get__api_student_hadiths_chapter_{chapterid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|chapterId|path|integer(int32)|true|none|

<h3 id="get__api_student_hadiths_chapter_{chapterid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_Hadiths_book_{bookId}

> Code samples

`GET /api/Student/Hadiths/book/{bookId}`

<h3 id="get__api_student_hadiths_book_{bookid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|bookId|path|integer(int32)|true|none|

<h3 id="get__api_student_hadiths_book_{bookid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_Hadiths_Search

> Code samples

`GET /api/Student/Hadiths/Search`

<h3 id="get__api_student_hadiths_search-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|query|query|string|false|none|

<h3 id="get__api_student_hadiths_search-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_Hadiths_englishNarrator_{name}

> Code samples

`GET /api/Student/Hadiths/englishNarrator/{name}`

<h3 id="get__api_student_hadiths_englishnarrator_{name}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|name|path|string|true|none|

<h3 id="get__api_student_hadiths_englishnarrator_{name}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_Hadiths_random

> Code samples

`GET /api/Student/Hadiths/random`

<h3 id="get__api_student_hadiths_random-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|bookId|query|integer(int32)|false|none|
|chapterId|query|integer(int32)|false|none|

<h3 id="get__api_student_hadiths_random-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_Hadiths_stats

> Code samples

`GET /api/Student/Hadiths/stats`

<h3 id="get__api_student_hadiths_stats-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Hadiths_GetAll

> Code samples

`GET /api/Admin/Hadiths/GetAll`

<h3 id="get__api_admin_hadiths_getall-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Hadiths_GetById_{id}

> Code samples

`GET /api/Admin/Hadiths/GetById/{id}`

<h3 id="get__api_admin_hadiths_getbyid_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_admin_hadiths_getbyid_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Hadiths_chapter_{chapterId}

> Code samples

`GET /api/Admin/Hadiths/chapter/{chapterId}`

<h3 id="get__api_admin_hadiths_chapter_{chapterid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|chapterId|path|integer(int32)|true|none|

<h3 id="get__api_admin_hadiths_chapter_{chapterid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Hadiths_book_{bookId}

> Code samples

`GET /api/Admin/Hadiths/book/{bookId}`

<h3 id="get__api_admin_hadiths_book_{bookid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|bookId|path|integer(int32)|true|none|

<h3 id="get__api_admin_hadiths_book_{bookid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Hadiths_Search

> Code samples

`GET /api/Admin/Hadiths/Search`

<h3 id="get__api_admin_hadiths_search-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|query|query|string|false|none|

<h3 id="get__api_admin_hadiths_search-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Hadiths_englishNarrator_{name}

> Code samples

`GET /api/Admin/Hadiths/englishNarrator/{name}`

<h3 id="get__api_admin_hadiths_englishnarrator_{name}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|name|path|string|true|none|

<h3 id="get__api_admin_hadiths_englishnarrator_{name}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Hadiths_random

> Code samples

`GET /api/Admin/Hadiths/random`

<h3 id="get__api_admin_hadiths_random-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|bookId|query|integer(int32)|false|none|
|chapterId|query|integer(int32)|false|none|

<h3 id="get__api_admin_hadiths_random-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Hadiths_stats

> Code samples

`GET /api/Admin/Hadiths/stats`

<h3 id="get__api_admin_hadiths_stats-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Admin_Hadiths_Create

> Code samples

`POST /api/Admin/Hadiths/Create`

> Body parameter

```json
{
  "idInBook": 0,
  "arabicText": "string",
  "normalizedText": "string",
  "englishNarrator": "string",
  "englishText": "string",
  "hadithChapterId": 0,
  "hadithBookId": 0
}
```

<h3 id="post__api_admin_hadiths_create-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[HadithRequest](#schemahadithrequest)|true|none|

<h3 id="post__api_admin_hadiths_create-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## put__api_Admin_Hadiths_Update_{id}

> Code samples

`PUT /api/Admin/Hadiths/Update/{id}`

> Body parameter

```json
{
  "idInBook": 0,
  "arabicText": "string",
  "normalizedText": "string",
  "englishNarrator": "string",
  "englishText": "string",
  "hadithChapterId": 0,
  "hadithBookId": 0
}
```

<h3 id="put__api_admin_hadiths_update_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|[HadithRequest](#schemahadithrequest)|true|none|

<h3 id="put__api_admin_hadiths_update_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## delete__api_Admin_Hadiths_Delete_{id}

> Code samples

`DELETE /api/Admin/Hadiths/Delete/{id}`

<h3 id="delete__api_admin_hadiths_delete_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="delete__api_admin_hadiths_delete_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_Admin_Hadiths_ToggleStatus_{id}

> Code samples

`PATCH /api/Admin/Hadiths/ToggleStatus/{id}`

<h3 id="patch__api_admin_hadiths_togglestatus_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="patch__api_admin_hadiths_togglestatus_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-category">Category</h1>

## get__api_Student_Category_GetAll

> Code samples

`GET /api/Student/Category/GetAll`

<h3 id="get__api_student_category_getall-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Student_Category_GetById_{id}

> Code samples

`GET /api/Student/Category/GetById/{id}`

<h3 id="get__api_student_category_getbyid_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_student_category_getbyid_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Category_GetAll

> Code samples

`GET /api/Admin/Category/GetAll`

<h3 id="get__api_admin_category_getall-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Admin_Category_GetById_{id}

> Code samples

`GET /api/Admin/Category/GetById/{id}`

<h3 id="get__api_admin_category_getbyid_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="get__api_admin_category_getbyid_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Admin_Category_Create

> Code samples

`POST /api/Admin/Category/Create`

> Body parameter

```yaml
Name: string
MainImage: string

```

<h3 id="post__api_admin_category_create-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|object|true|none|
|» Name|body|string|false|none|
|» MainImage|body|[IFormFile](#schemaiformfile)(binary)|false|none|

<h3 id="post__api_admin_category_create-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_Admin_Category_Update_{id}

> Code samples

`PATCH /api/Admin/Category/Update/{id}`

> Body parameter

```yaml
Name: string
MainImage: string

```

<h3 id="patch__api_admin_category_update_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|object|true|none|
|» Name|body|string|false|none|
|» MainImage|body|[IFormFile](#schemaiformfile)(binary)|false|none|

<h3 id="patch__api_admin_category_update_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## patch__api_Admin_Category_ToggleStatus_{id}

> Code samples

`PATCH /api/Admin/Category/ToggleStatus/{id}`

<h3 id="patch__api_admin_category_togglestatus_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="patch__api_admin_category_togglestatus_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## delete__api_Admin_Category_Delete_{id}

> Code samples

`DELETE /api/Admin/Category/Delete/{id}`

<h3 id="delete__api_admin_category_delete_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="delete__api_admin_category_delete_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="pl-v1-authentication">Authentication</h1>

## post__api_Identity_Authentication_Refresh

> Code samples

`POST /api/Identity/Authentication/Refresh`

> Body parameter

```json
{
  "refreshToken": "string"
}
```

<h3 id="post__api_identity_authentication_refresh-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[RefreshTokenRequest](#schemarefreshtokenrequest)|true|none|

> Example responses

> 200 Response

```
{"accessToken":"string","refreshToken":"string"}
```

```json
{
  "accessToken": "string",
  "refreshToken": "string"
}
```

<h3 id="post__api_identity_authentication_refresh-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[UserDto](#schemauserdto)|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Identity_Authentication_Register

> Code samples

`POST /api/Identity/Authentication/Register`

> Body parameter

```json
{
  "fullName": "string",
  "userName": "string",
  "email": "string",
  "password": "string",
  "phoneNumber": "string"
}
```

<h3 id="post__api_identity_authentication_register-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[RegisterRequest](#schemaregisterrequest)|true|none|

> Example responses

> 200 Response

```
{"accessToken":"string","refreshToken":"string"}
```

```json
{
  "accessToken": "string",
  "refreshToken": "string"
}
```

<h3 id="post__api_identity_authentication_register-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[UserDto](#schemauserdto)|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Identity_Authentication_Login

> Code samples

`POST /api/Identity/Authentication/Login`

> Body parameter

```json
{
  "email": "string",
  "password": "string"
}
```

<h3 id="post__api_identity_authentication_login-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[LoginRequest](#schemaloginrequest)|true|none|

> Example responses

> 200 Response

```
{"accessToken":"string","refreshToken":"string"}
```

```json
{
  "accessToken": "string",
  "refreshToken": "string"
}
```

<h3 id="post__api_identity_authentication_login-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[UserDto](#schemauserdto)|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Identity_Authentication_Logout

> Code samples

`POST /api/Identity/Authentication/Logout`

<h3 id="post__api_identity_authentication_logout-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_Identity_Authentication_ConfirmEmail

> Code samples

`GET /api/Identity/Authentication/ConfirmEmail`

<h3 id="get__api_identity_authentication_confirmemail-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|token|query|string|false|none|
|userId|query|string|false|none|

> Example responses

> 200 Response

```
"string"
```

```json
"string"
```

<h3 id="get__api_identity_authentication_confirmemail-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|string|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Identity_Authentication_ForgotPassword

> Code samples

`POST /api/Identity/Authentication/ForgotPassword`

> Body parameter

```json
{
  "email": "string"
}
```

<h3 id="post__api_identity_authentication_forgotpassword-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[ForgotPasswordRequest](#schemaforgotpasswordrequest)|true|none|

> Example responses

> 200 Response

```
"string"
```

```json
"string"
```

<h3 id="post__api_identity_authentication_forgotpassword-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|string|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Identity_Authentication_ResetPassword

> Code samples

`POST /api/Identity/Authentication/ResetPassword`

> Body parameter

```json
{
  "newPassword": "string",
  "email": "string",
  "code": "string"
}
```

<h3 id="post__api_identity_authentication_resetpassword-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[ResetPasswordRequest](#schemaresetpasswordrequest)|true|none|

> Example responses

> 200 Response

```
"string"
```

```json
"string"
```

<h3 id="post__api_identity_authentication_resetpassword-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|string|

<aside class="success">
This operation does not require authentication
</aside>

# Schemas

<h2 id="tocS_ChangeEmailRequest">ChangeEmailRequest</h2>
<!-- backwards compatibility -->
<a id="schemachangeemailrequest"></a>
<a id="schema_ChangeEmailRequest"></a>
<a id="tocSchangeemailrequest"></a>
<a id="tocschangeemailrequest"></a>

```json
{
  "newEmail": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|newEmail|string|false|none|none|

<h2 id="tocS_ChangePasswordRequest">ChangePasswordRequest</h2>
<!-- backwards compatibility -->
<a id="schemachangepasswordrequest"></a>
<a id="schema_ChangePasswordRequest"></a>
<a id="tocSchangepasswordrequest"></a>
<a id="tocschangepasswordrequest"></a>

```json
{
  "currentPassword": "string",
  "newPassword": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|currentPassword|string|false|none|none|
|newPassword|string|false|none|none|

<h2 id="tocS_ChangeRoleRequest">ChangeRoleRequest</h2>
<!-- backwards compatibility -->
<a id="schemachangerolerequest"></a>
<a id="schema_ChangeRoleRequest"></a>
<a id="tocSchangerolerequest"></a>
<a id="tocschangerolerequest"></a>

```json
{
  "roleName": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|roleName|string|false|none|none|

<h2 id="tocS_FilesTypes">FilesTypes</h2>
<!-- backwards compatibility -->
<a id="schemafilestypes"></a>
<a id="schema_FilesTypes"></a>
<a id="tocSfilestypes"></a>
<a id="tocsfilestypes"></a>

```json
0

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|integer|false|none|none|

<h2 id="tocS_ForgotPasswordRequest">ForgotPasswordRequest</h2>
<!-- backwards compatibility -->
<a id="schemaforgotpasswordrequest"></a>
<a id="schema_ForgotPasswordRequest"></a>
<a id="tocSforgotpasswordrequest"></a>
<a id="tocsforgotpasswordrequest"></a>

```json
{
  "email": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|email|string|false|none|none|

<h2 id="tocS_HadithBookRequest">HadithBookRequest</h2>
<!-- backwards compatibility -->
<a id="schemahadithbookrequest"></a>
<a id="schema_HadithBookRequest"></a>
<a id="tocShadithbookrequest"></a>
<a id="tocshadithbookrequest"></a>

```json
{
  "arabicTitle": "string",
  "arabicAuthor": "string",
  "arabicIntroduction": "string",
  "englishTitle": "string",
  "englishAuthor": "string",
  "englishIntroduction": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|arabicTitle|string|false|none|none|
|arabicAuthor|string|false|none|none|
|arabicIntroduction|string|false|none|none|
|englishTitle|string|false|none|none|
|englishAuthor|string|false|none|none|
|englishIntroduction|string|false|none|none|

<h2 id="tocS_HadithChapterRequest">HadithChapterRequest</h2>
<!-- backwards compatibility -->
<a id="schemahadithchapterrequest"></a>
<a id="schema_HadithChapterRequest"></a>
<a id="tocShadithchapterrequest"></a>
<a id="tocshadithchapterrequest"></a>

```json
{
  "arabicTitle": "string",
  "englishTitle": "string",
  "hadithBookId": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|arabicTitle|string|false|none|none|
|englishTitle|string|false|none|none|
|hadithBookId|integer(int32)|false|none|none|

<h2 id="tocS_HadithRequest">HadithRequest</h2>
<!-- backwards compatibility -->
<a id="schemahadithrequest"></a>
<a id="schema_HadithRequest"></a>
<a id="tocShadithrequest"></a>
<a id="tocshadithrequest"></a>

```json
{
  "idInBook": 0,
  "arabicText": "string",
  "normalizedText": "string",
  "englishNarrator": "string",
  "englishText": "string",
  "hadithChapterId": 0,
  "hadithBookId": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|idInBook|integer(int32)|false|none|none|
|arabicText|string|false|none|none|
|normalizedText|string|false|none|none|
|englishNarrator|string|false|none|none|
|englishText|string|false|none|none|
|hadithChapterId|integer(int32)|false|none|none|
|hadithBookId|integer(int32)|false|none|none|

<h2 id="tocS_IFormFile">IFormFile</h2>
<!-- backwards compatibility -->
<a id="schemaiformfile"></a>
<a id="schema_IFormFile"></a>
<a id="tocSiformfile"></a>
<a id="tocsiformfile"></a>

```json
"string"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string(binary)|false|none|none|

<h2 id="tocS_LoginRequest">LoginRequest</h2>
<!-- backwards compatibility -->
<a id="schemaloginrequest"></a>
<a id="schema_LoginRequest"></a>
<a id="tocSloginrequest"></a>
<a id="tocsloginrequest"></a>

```json
{
  "email": "string",
  "password": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|email|string|false|none|none|
|password|string|false|none|none|

<h2 id="tocS_ProgressCreateRequest">ProgressCreateRequest</h2>
<!-- backwards compatibility -->
<a id="schemaprogresscreaterequest"></a>
<a id="schema_ProgressCreateRequest"></a>
<a id="tocSprogresscreaterequest"></a>
<a id="tocsprogresscreaterequest"></a>

```json
{
  "type": "Thikr",
  "relatedItemId": 0,
  "count": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[ProgressType](#schemaprogresstype)|false|none|none|
|relatedItemId|integer(int32)¦null|false|none|none|
|count|integer(int32)|false|none|none|

<h2 id="tocS_ProgressType">ProgressType</h2>
<!-- backwards compatibility -->
<a id="schemaprogresstype"></a>
<a id="schema_ProgressType"></a>
<a id="tocSprogresstype"></a>
<a id="tocsprogresstype"></a>

```json
"Thikr"

```

### Properties

*None*

<h2 id="tocS_QuestionRequest">QuestionRequest</h2>
<!-- backwards compatibility -->
<a id="schemaquestionrequest"></a>
<a id="schema_QuestionRequest"></a>
<a id="tocSquestionrequest"></a>
<a id="tocsquestionrequest"></a>

```json
{
  "text": "string",
  "correctAnswer": "string",
  "options": [
    "string"
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|text|string|false|none|none|
|correctAnswer|string|false|none|none|
|options|[string]|false|none|none|

<h2 id="tocS_QuizRequest">QuizRequest</h2>
<!-- backwards compatibility -->
<a id="schemaquizrequest"></a>
<a id="schema_QuizRequest"></a>
<a id="tocSquizrequest"></a>
<a id="tocsquizrequest"></a>

```json
{
  "title": "string",
  "lessonId": 0,
  "questions": [
    {
      "text": "string",
      "correctAnswer": "string",
      "options": [
        "string"
      ]
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|title|string|false|none|none|
|lessonId|integer(int32)|false|none|none|
|questions|[[QuestionRequest](#schemaquestionrequest)]|false|none|none|

<h2 id="tocS_RefreshTokenRequest">RefreshTokenRequest</h2>
<!-- backwards compatibility -->
<a id="schemarefreshtokenrequest"></a>
<a id="schema_RefreshTokenRequest"></a>
<a id="tocSrefreshtokenrequest"></a>
<a id="tocsrefreshtokenrequest"></a>

```json
{
  "refreshToken": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|refreshToken|string|false|none|none|

<h2 id="tocS_RegisterRequest">RegisterRequest</h2>
<!-- backwards compatibility -->
<a id="schemaregisterrequest"></a>
<a id="schema_RegisterRequest"></a>
<a id="tocSregisterrequest"></a>
<a id="tocsregisterrequest"></a>

```json
{
  "fullName": "string",
  "userName": "string",
  "email": "string",
  "password": "string",
  "phoneNumber": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|fullName|string|false|none|none|
|userName|string|false|none|none|
|email|string|false|none|none|
|password|string|false|none|none|
|phoneNumber|string|false|none|none|

<h2 id="tocS_ResetPasswordRequest">ResetPasswordRequest</h2>
<!-- backwards compatibility -->
<a id="schemaresetpasswordrequest"></a>
<a id="schema_ResetPasswordRequest"></a>
<a id="tocSresetpasswordrequest"></a>
<a id="tocsresetpasswordrequest"></a>

```json
{
  "newPassword": "string",
  "email": "string",
  "code": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|newPassword|string|false|none|none|
|email|string|false|none|none|
|code|string|false|none|none|

<h2 id="tocS_ThikrCategoryRequest">ThikrCategoryRequest</h2>
<!-- backwards compatibility -->
<a id="schemathikrcategoryrequest"></a>
<a id="schema_ThikrCategoryRequest"></a>
<a id="tocSthikrcategoryrequest"></a>
<a id="tocsthikrcategoryrequest"></a>

```json
{
  "title": "string",
  "normalizedText": "string",
  "audioUrl": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|title|string|false|none|none|
|normalizedText|string|false|none|none|
|audioUrl|string|false|none|none|

<h2 id="tocS_ThikrItemRequest">ThikrItemRequest</h2>
<!-- backwards compatibility -->
<a id="schemathikritemrequest"></a>
<a id="schema_ThikrItemRequest"></a>
<a id="tocSthikritemrequest"></a>
<a id="tocsthikritemrequest"></a>

```json
{
  "text": "string",
  "normalizedText": "string",
  "count": 0,
  "description": "string",
  "reference": "string",
  "thikrCategoryId": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|text|string|false|none|none|
|normalizedText|string|false|none|none|
|count|integer(int32)|false|none|none|
|description|string|false|none|none|
|reference|string|false|none|none|
|thikrCategoryId|integer(int32)|false|none|none|

<h2 id="tocS_UpdateProfileRequest">UpdateProfileRequest</h2>
<!-- backwards compatibility -->
<a id="schemaupdateprofilerequest"></a>
<a id="schema_UpdateProfileRequest"></a>
<a id="tocSupdateprofilerequest"></a>
<a id="tocsupdateprofilerequest"></a>

```json
{
  "fullName": "string",
  "userName": "string",
  "phoneNumber": "string",
  "city": "string",
  "street": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|fullName|string|false|none|none|
|userName|string|false|none|none|
|phoneNumber|string|false|none|none|
|city|string|false|none|none|
|street|string|false|none|none|

<h2 id="tocS_UserDto">UserDto</h2>
<!-- backwards compatibility -->
<a id="schemauserdto"></a>
<a id="schema_UserDto"></a>
<a id="tocSuserdto"></a>
<a id="tocsuserdto"></a>

```json
{
  "accessToken": "string",
  "refreshToken": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|accessToken|string|false|none|none|
|refreshToken|string|false|none|none|

