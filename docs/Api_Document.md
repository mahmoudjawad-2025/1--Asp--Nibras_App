## Access

## Methods

\[ Jump to [Models](#__Models) \]

### Table of Contents

#### [Authentication](#Authentication)

*   [`get /api/Identity/Authentication/ConfirmEmail`](#apiIdentityAuthenticationConfirmEmailGet)
*   [`post /api/Identity/Authentication/ForgotPassword`](#apiIdentityAuthenticationForgotPasswordPost)
*   [`post /api/Identity/Authentication/Login`](#apiIdentityAuthenticationLoginPost)
*   [`post /api/Identity/Authentication/Logout`](#apiIdentityAuthenticationLogoutPost)
*   [`post /api/Identity/Authentication/Refresh`](#apiIdentityAuthenticationRefreshPost)
*   [`post /api/Identity/Authentication/Register`](#apiIdentityAuthenticationRegisterPost)
*   [`post /api/Identity/Authentication/ResetPassword`](#apiIdentityAuthenticationResetPasswordPost)

#### [Category](#Category)

*   [`post /api/Admin/Category/Create`](#apiAdminCategoryCreatePost)
*   [`delete /api/Admin/Category/Delete/{id}`](#apiAdminCategoryDeleteIdDelete)
*   [`get /api/Admin/Category/GetAll`](#apiAdminCategoryGetAllGet)
*   [`get /api/Admin/Category/GetById/{id}`](#apiAdminCategoryGetByIdIdGet)
*   [`patch /api/Admin/Category/ToggleStatus/{id}`](#apiAdminCategoryToggleStatusIdPatch)
*   [`patch /api/Admin/Category/Update/{id}`](#apiAdminCategoryUpdateIdPatch)
*   [`get /api/Student/Category/GetAll`](#apiStudentCategoryGetAllGet)
*   [`get /api/Student/Category/GetById/{id}`](#apiStudentCategoryGetByIdIdGet)

#### [Course](#Course)

*   [`post /api/Admin/Course/Create`](#apiAdminCourseCreatePost)
*   [`delete /api/Admin/Course/Delete/{id}`](#apiAdminCourseDeleteIdDelete)
*   [`get /api/Admin/Course/GetAll`](#apiAdminCourseGetAllGet)
*   [`get /api/Admin/Course/GetById/{id}`](#apiAdminCourseGetByIdIdGet)
*   [`patch /api/Admin/Course/ToggleStatus/{id}`](#apiAdminCourseToggleStatusIdPatch)
*   [`put /api/Admin/Course/Update/{id}`](#apiAdminCourseUpdateIdPut)
*   [`get /api/Student/Course/GetAll`](#apiStudentCourseGetAllGet)
*   [`get /api/Student/Course/GetById/{id}`](#apiStudentCourseGetByIdIdGet)

#### [HadithBooks](#HadithBooks)

*   [`post /api/Admin/HadithBooks/Create`](#apiAdminHadithBooksCreatePost)
*   [`delete /api/Admin/HadithBooks/Delete/{id}`](#apiAdminHadithBooksDeleteIdDelete)
*   [`get /api/Admin/HadithBooks/GetAll`](#apiAdminHadithBooksGetAllGet)
*   [`get /api/Admin/HadithBooks/GetById/{id}`](#apiAdminHadithBooksGetByIdIdGet)
*   [`get /api/Admin/HadithBooks/{id}/chapters`](#apiAdminHadithBooksIdChaptersGet)
*   [`get /api/Admin/HadithBooks/{id}/hadiths`](#apiAdminHadithBooksIdHadithsGet)
*   [`get /api/Admin/HadithBooks/{id}/random`](#apiAdminHadithBooksIdRandomGet)
*   [`get /api/Admin/HadithBooks/{id}/stats`](#apiAdminHadithBooksIdStatsGet)
*   [`get /api/Admin/HadithBooks/Search`](#apiAdminHadithBooksSearchGet)
*   [`patch /api/Admin/HadithBooks/ToggleStatus/{id}`](#apiAdminHadithBooksToggleStatusIdPatch)
*   [`put /api/Admin/HadithBooks/Update/{id}`](#apiAdminHadithBooksUpdateIdPut)
*   [`get /api/Student/HadithBooks/GetAll`](#apiStudentHadithBooksGetAllGet)
*   [`get /api/Student/HadithBooks/GetById/{id}`](#apiStudentHadithBooksGetByIdIdGet)
*   [`get /api/Student/HadithBooks/{id}/chapters`](#apiStudentHadithBooksIdChaptersGet)
*   [`get /api/Student/HadithBooks/{id}/hadiths`](#apiStudentHadithBooksIdHadithsGet)
*   [`get /api/Student/HadithBooks/{id}/random`](#apiStudentHadithBooksIdRandomGet)
*   [`get /api/Student/HadithBooks/{id}/stats`](#apiStudentHadithBooksIdStatsGet)
*   [`get /api/Student/HadithBooks/Search`](#apiStudentHadithBooksSearchGet)

#### [HadithChapters](#HadithChapters)

*   [`get /api/Admin/HadithChapters/book/{bookId}`](#apiAdminHadithChaptersBookBookIdGet)
*   [`post /api/Admin/HadithChapters/Create`](#apiAdminHadithChaptersCreatePost)
*   [`delete /api/Admin/HadithChapters/Delete/{id}`](#apiAdminHadithChaptersDeleteIdDelete)
*   [`get /api/Admin/HadithChapters/GetAll`](#apiAdminHadithChaptersGetAllGet)
*   [`get /api/Admin/HadithChapters/GetById/{id}`](#apiAdminHadithChaptersGetByIdIdGet)
*   [`get /api/Admin/HadithChapters/{id}/hadiths`](#apiAdminHadithChaptersIdHadithsGet)
*   [`get /api/Admin/HadithChapters/{id}/random`](#apiAdminHadithChaptersIdRandomGet)
*   [`get /api/Admin/HadithChapters/{id}/stats`](#apiAdminHadithChaptersIdStatsGet)
*   [`get /api/Admin/HadithChapters/Search`](#apiAdminHadithChaptersSearchGet)
*   [`patch /api/Admin/HadithChapters/ToggleStatus/{id}`](#apiAdminHadithChaptersToggleStatusIdPatch)
*   [`put /api/Admin/HadithChapters/Update/{id}`](#apiAdminHadithChaptersUpdateIdPut)
*   [`get /api/Student/HadithChapters/book/{bookId}`](#apiStudentHadithChaptersBookBookIdGet)
*   [`get /api/Student/HadithChapters/GetAll`](#apiStudentHadithChaptersGetAllGet)
*   [`get /api/Student/HadithChapters/GetById/{id}`](#apiStudentHadithChaptersGetByIdIdGet)
*   [`get /api/Student/HadithChapters/{id}/hadiths`](#apiStudentHadithChaptersIdHadithsGet)
*   [`get /api/Student/HadithChapters/{id}/random`](#apiStudentHadithChaptersIdRandomGet)
*   [`get /api/Student/HadithChapters/{id}/stats`](#apiStudentHadithChaptersIdStatsGet)
*   [`get /api/Student/HadithChapters/Search`](#apiStudentHadithChaptersSearchGet)

#### [Hadiths](#Hadiths)

*   [`get /api/Admin/Hadiths/book/{bookId}`](#apiAdminHadithsBookBookIdGet)
*   [`get /api/Admin/Hadiths/chapter/{chapterId}`](#apiAdminHadithsChapterChapterIdGet)
*   [`post /api/Admin/Hadiths/Create`](#apiAdminHadithsCreatePost)
*   [`delete /api/Admin/Hadiths/Delete/{id}`](#apiAdminHadithsDeleteIdDelete)
*   [`get /api/Admin/Hadiths/englishNarrator/{name}`](#apiAdminHadithsEnglishNarratorNameGet)
*   [`get /api/Admin/Hadiths/GetAll`](#apiAdminHadithsGetAllGet)
*   [`get /api/Admin/Hadiths/GetById/{id}`](#apiAdminHadithsGetByIdIdGet)
*   [`get /api/Admin/Hadiths/random`](#apiAdminHadithsRandomGet)
*   [`get /api/Admin/Hadiths/Search`](#apiAdminHadithsSearchGet)
*   [`get /api/Admin/Hadiths/stats`](#apiAdminHadithsStatsGet)
*   [`patch /api/Admin/Hadiths/ToggleStatus/{id}`](#apiAdminHadithsToggleStatusIdPatch)
*   [`put /api/Admin/Hadiths/Update/{id}`](#apiAdminHadithsUpdateIdPut)
*   [`get /api/Student/Hadiths/book/{bookId}`](#apiStudentHadithsBookBookIdGet)
*   [`get /api/Student/Hadiths/chapter/{chapterId}`](#apiStudentHadithsChapterChapterIdGet)
*   [`get /api/Student/Hadiths/englishNarrator/{name}`](#apiStudentHadithsEnglishNarratorNameGet)
*   [`get /api/Student/Hadiths/GetAll`](#apiStudentHadithsGetAllGet)
*   [`get /api/Student/Hadiths/GetById/{id}`](#apiStudentHadithsGetByIdIdGet)
*   [`get /api/Student/Hadiths/random`](#apiStudentHadithsRandomGet)
*   [`get /api/Student/Hadiths/Search`](#apiStudentHadithsSearchGet)
*   [`get /api/Student/Hadiths/stats`](#apiStudentHadithsStatsGet)

#### [Lesson](#Lesson)

*   [`post /api/Admin/Lesson/Create`](#apiAdminLessonCreatePost)
*   [`delete /api/Admin/Lesson/Delete/{id}`](#apiAdminLessonDeleteIdDelete)
*   [`get /api/Admin/Lesson/GetAll`](#apiAdminLessonGetAllGet)
*   [`get /api/Admin/Lesson/GetByCourseId/{courseId}`](#apiAdminLessonGetByCourseIdCourseIdGet)
*   [`get /api/Admin/Lesson/GetById/{id}`](#apiAdminLessonGetByIdIdGet)
*   [`patch /api/Admin/Lesson/ToggleStatus/{id}`](#apiAdminLessonToggleStatusIdPatch)
*   [`put /api/Admin/Lesson/Update/{id}`](#apiAdminLessonUpdateIdPut)
*   [`get /api/Student/Lesson/GetAll`](#apiStudentLessonGetAllGet)
*   [`get /api/Student/Lesson/GetByCourseId/{courseId}`](#apiStudentLessonGetByCourseIdCourseIdGet)
*   [`get /api/Student/Lesson/GetById/{id}`](#apiStudentLessonGetByIdIdGet)

#### [Quiz](#Quiz)

*   [`post /api/Admin/Quiz/Create`](#apiAdminQuizCreatePost)
*   [`delete /api/Admin/Quiz/Delete/{id}`](#apiAdminQuizDeleteIdDelete)
*   [`get /api/Admin/Quiz/GetAll`](#apiAdminQuizGetAllGet)
*   [`get /api/Admin/Quiz/GetById/{id}`](#apiAdminQuizGetByIdIdGet)
*   [`patch /api/Admin/Quiz/ToggleStatus/{id}`](#apiAdminQuizToggleStatusIdPatch)
*   [`put /api/Admin/Quiz/Update/{id}`](#apiAdminQuizUpdateIdPut)
*   [`get /api/Student/Quiz/GetAll`](#apiStudentQuizGetAllGet)
*   [`get /api/Student/Quiz/GetById/{id}`](#apiStudentQuizGetByIdIdGet)

#### [Quran](#Quran)

*   [`get /api/Admin/Quran/SearchGeneric`](#apiAdminQuranSearchGenericGet)
*   [`get /api/Admin/Quran/search`](#apiAdminQuranSearchGet)
*   [`get /api/Admin/Quran/surahs`](#apiAdminQuranSurahsGet)
*   [`get /api/Admin/Quran/surahs/{number}`](#apiAdminQuranSurahsNumberGet)
*   [`get /api/Admin/Quran/surahs/{surahNumber}/ayahs/{ayahNumber}`](#apiAdminQuranSurahsSurahNumberAyahsAyahNumberGet)
*   [`get /api/Student/Quran/SearchGeneric`](#apiStudentQuranSearchGenericGet)
*   [`get /api/Student/Quran/search`](#apiStudentQuranSearchGet)
*   [`get /api/Student/Quran/surahs`](#apiStudentQuranSurahsGet)
*   [`get /api/Student/Quran/surahs/{number}`](#apiStudentQuranSurahsNumberGet)
*   [`get /api/Student/Quran/surahs/{surahNumber}/ayahs/{ayahNumber}`](#apiStudentQuranSurahsSurahNumberAyahsAyahNumberGet)

#### [ThikrCategory](#ThikrCategory)

*   [`post /api/Admin/ThikrCategory/Create`](#apiAdminThikrCategoryCreatePost)
*   [`delete /api/Admin/ThikrCategory/Delete/{id}`](#apiAdminThikrCategoryDeleteIdDelete)
*   [`get /api/Admin/ThikrCategory/GetAll`](#apiAdminThikrCategoryGetAllGet)
*   [`get /api/Admin/ThikrCategory/GetAudioUrls`](#apiAdminThikrCategoryGetAudioUrlsGet)
*   [`get /api/Admin/ThikrCategory/GetById/{id}`](#apiAdminThikrCategoryGetByIdIdGet)
*   [`get /api/Admin/ThikrCategory/Search`](#apiAdminThikrCategorySearchGet)
*   [`patch /api/Admin/ThikrCategory/ToggleStatus/{id}`](#apiAdminThikrCategoryToggleStatusIdPatch)
*   [`put /api/Admin/ThikrCategory/Update/{id}`](#apiAdminThikrCategoryUpdateIdPut)
*   [`get /api/Student/ThikrCategory/GetAll`](#apiStudentThikrCategoryGetAllGet)
*   [`get /api/Student/ThikrCategory/GetById/{id}`](#apiStudentThikrCategoryGetByIdIdGet)
*   [`get /api/Student/ThikrCategory/Search`](#apiStudentThikrCategorySearchGet)

#### [ThikrItem](#ThikrItem)

*   [`post /api/Admin/ThikrItem/Create`](#apiAdminThikrItemCreatePost)
*   [`delete /api/Admin/ThikrItem/Delete/{id}`](#apiAdminThikrItemDeleteIdDelete)
*   [`get /api/Admin/ThikrItem/GetAll`](#apiAdminThikrItemGetAllGet)
*   [`get /api/Admin/ThikrItem/GetByCategoryId/{categoryId}`](#apiAdminThikrItemGetByCategoryIdCategoryIdGet)
*   [`get /api/Admin/ThikrItem/GetByCount`](#apiAdminThikrItemGetByCountGet)
*   [`get /api/Admin/ThikrItem/GetById/{id}`](#apiAdminThikrItemGetByIdIdGet)
*   [`get /api/Admin/ThikrItem/Search`](#apiAdminThikrItemSearchGet)
*   [`patch /api/Admin/ThikrItem/ToggleStatus/{id}`](#apiAdminThikrItemToggleStatusIdPatch)
*   [`put /api/Admin/ThikrItem/Update/{id}`](#apiAdminThikrItemUpdateIdPut)
*   [`get /api/Student/ThikrItem/GetAll`](#apiStudentThikrItemGetAllGet)
*   [`get /api/Student/ThikrItem/GetByCategoryId/{categoryId}`](#apiStudentThikrItemGetByCategoryIdCategoryIdGet)
*   [`get /api/Student/ThikrItem/GetByCount`](#apiStudentThikrItemGetByCountGet)
*   [`get /api/Student/ThikrItem/GetById/{id}`](#apiStudentThikrItemGetByIdIdGet)
*   [`get /api/Student/ThikrItem/Search`](#apiStudentThikrItemSearchGet)

#### [User](#User)

*   [`patch /api/Admin/User/BlockUser/{userId}`](#apiAdminUserBlockUserUserIdPatch)
*   [`put /api/Admin/User/ChangeEmail`](#apiAdminUserChangeEmailPut)
*   [`put /api/Admin/User/ChangePassword`](#apiAdminUserChangePasswordPut)
*   [`patch /api/Admin/User/ChangeRole/{userId}`](#apiAdminUserChangeRoleUserIdPatch)
*   [`get /api/Admin/User/ConfirmNewEmail`](#apiAdminUserConfirmNewEmailGet)
*   [`get /api/Admin/User/GetAllUsers`](#apiAdminUserGetAllUsersGet)
*   [`get /api/Admin/User/GetMyProfile`](#apiAdminUserGetMyProfileGet)
*   [`get /api/Admin/User/GetUserById/{id}`](#apiAdminUserGetUserByIdIdGet)
*   [`patch /api/Admin/User/IsBlockedUser/{userId}`](#apiAdminUserIsBlockedUserUserIdPatch)
*   [`patch /api/Admin/User/UnBlockUser/{userId}`](#apiAdminUserUnBlockUserUserIdPatch)
*   [`put /api/Admin/User/UpdateMyProfile`](#apiAdminUserUpdateMyProfilePut)
*   [`put /api/Student/User/ChangeEmail`](#apiStudentUserChangeEmailPut)
*   [`put /api/Student/User/ChangePassword`](#apiStudentUserChangePasswordPut)
*   [`get /api/Student/User/ConfirmNewEmail`](#apiStudentUserConfirmNewEmailGet)
*   [`get /api/Student/User/GetMyProfile`](#apiStudentUserGetMyProfileGet)
*   [`put /api/Student/User/UpdateMyProfile`](#apiStudentUserUpdateMyProfilePut)

#### [UserProgress](#UserProgress)

*   [`post /api/Admin/UserProgress/add`](#apiAdminUserProgressAddPost)
*   [`get /api/Admin/UserProgress/me`](#apiAdminUserProgressMeGet)
*   [`post /api/Student/UserProgress/add`](#apiStudentUserProgressAddPost)
*   [`get /api/Student/UserProgress/me`](#apiStudentUserProgressMeGet)

# Authentication

[Up](#__Methods)

```
get /api/Identity/Authentication/ConfirmEmail
```

(apiIdentityAuthenticationConfirmEmailGet)

### Query parameters

token (optional)

Query Parameter —

userId (optional)

Query Parameter —

### Return type

String

### Example data

Content-Type: application/json

```
""
```

### Produces

This API call produces the following media types according to the Accept request header; the media type will be conveyed by the Content-Type response header.

*   `text/plain`
*   `application/json`
*   `text/json`

### Responses

#### 200

OK [String](#String)

- - -

[Up](#__Methods)

```
post /api/Identity/Authentication/ForgotPassword
```

(apiIdentityAuthenticationForgotPasswordPost)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [ForgotPasswordRequest](#ForgotPasswordRequest) (required)

Body Parameter —

### Return type

String

### Example data

Content-Type: application/json

```
""
```

### Produces

This API call produces the following media types according to the Accept request header; the media type will be conveyed by the Content-Type response header.

*   `text/plain`
*   `application/json`
*   `text/json`

### Responses

#### 200

OK [String](#String)

- - -

[Up](#__Methods)

```
post /api/Identity/Authentication/Login
```

(apiIdentityAuthenticationLoginPost)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [LoginRequest](#LoginRequest) (required)

Body Parameter —

### Return type

[UserDto](#UserDto)

### Example data

Content-Type: application/json

```
{
  "accessToken" : "accessToken",
  "refreshToken" : "refreshToken"
}
```

### Produces

This API call produces the following media types according to the Accept request header; the media type will be conveyed by the Content-Type response header.

*   `text/plain`
*   `application/json`
*   `text/json`

### Responses

#### 200

OK [UserDto](#UserDto)

- - -

[Up](#__Methods)

```
post /api/Identity/Authentication/Logout
```

(apiIdentityAuthenticationLogoutPost)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
post /api/Identity/Authentication/Refresh
```

(apiIdentityAuthenticationRefreshPost)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [RefreshTokenRequest](#RefreshTokenRequest) (required)

Body Parameter —

### Return type

[UserDto](#UserDto)

### Example data

Content-Type: application/json

```
{
  "accessToken" : "accessToken",
  "refreshToken" : "refreshToken"
}
```

### Produces

This API call produces the following media types according to the Accept request header; the media type will be conveyed by the Content-Type response header.

*   `text/plain`
*   `application/json`
*   `text/json`

### Responses

#### 200

OK [UserDto](#UserDto)

- - -

[Up](#__Methods)

```
post /api/Identity/Authentication/Register
```

(apiIdentityAuthenticationRegisterPost)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [RegisterRequest](#RegisterRequest) (required)

Body Parameter —

### Return type

[UserDto](#UserDto)

### Example data

Content-Type: application/json

```
{
  "accessToken" : "accessToken",
  "refreshToken" : "refreshToken"
}
```

### Produces

This API call produces the following media types according to the Accept request header; the media type will be conveyed by the Content-Type response header.

*   `text/plain`
*   `application/json`
*   `text/json`

### Responses

#### 200

OK [UserDto](#UserDto)

- - -

[Up](#__Methods)

```
post /api/Identity/Authentication/ResetPassword
```

(apiIdentityAuthenticationResetPasswordPost)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [ResetPasswordRequest](#ResetPasswordRequest) (required)

Body Parameter —

### Return type

String

### Example data

Content-Type: application/json

```
""
```

### Produces

This API call produces the following media types according to the Accept request header; the media type will be conveyed by the Content-Type response header.

*   `text/plain`
*   `application/json`
*   `text/json`

### Responses

#### 200

OK [String](#String)

- - -

# Category

[Up](#__Methods)

```
post /api/Admin/Category/Create
```

(apiAdminCategoryCreatePost)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/x-www-form-urlencoded`

### Form parameters

Name (required)

Form Parameter —

MainImage (required)

Form Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
delete /api/Admin/Category/Delete/{id}
```

(apiAdminCategoryDeleteIdDelete)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/Category/GetAll
```

(apiAdminCategoryGetAllGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/Category/GetById/{id}
```

(apiAdminCategoryGetByIdIdGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
patch /api/Admin/Category/ToggleStatus/{id}
```

(apiAdminCategoryToggleStatusIdPatch)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
patch /api/Admin/Category/Update/{id}
```

(apiAdminCategoryUpdateIdPatch)

### Path parameters

id (required)

Path Parameter — format: int32

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/x-www-form-urlencoded`

### Form parameters

Name (required)

Form Parameter —

MainImage (required)

Form Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Category/GetAll
```

(apiStudentCategoryGetAllGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Category/GetById/{id}
```

(apiStudentCategoryGetByIdIdGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

# Course

[Up](#__Methods)

```
post /api/Admin/Course/Create
```

(apiAdminCourseCreatePost)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/x-www-form-urlencoded`

### Form parameters

Title (required)

Form Parameter —

Description (required)

Form Parameter —

CategoryId (required)

Form Parameter — format: int32

LessonIds (required)

Form Parameter — format: int32

MainImage (required)

Form Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
delete /api/Admin/Course/Delete/{id}
```

(apiAdminCourseDeleteIdDelete)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/Course/GetAll
```

(apiAdminCourseGetAllGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/Course/GetById/{id}
```

(apiAdminCourseGetByIdIdGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
patch /api/Admin/Course/ToggleStatus/{id}
```

(apiAdminCourseToggleStatusIdPatch)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
put /api/Admin/Course/Update/{id}
```

(apiAdminCourseUpdateIdPut)

### Path parameters

id (required)

Path Parameter — format: int32

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/x-www-form-urlencoded`

### Form parameters

Title (required)

Form Parameter —

Description (required)

Form Parameter —

CategoryId (required)

Form Parameter — format: int32

LessonIds (required)

Form Parameter — format: int32

MainImage (required)

Form Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Course/GetAll
```

(apiStudentCourseGetAllGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Course/GetById/{id}
```

(apiStudentCourseGetByIdIdGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

# HadithBooks

[Up](#__Methods)

```
post /api/Admin/HadithBooks/Create
```

(apiAdminHadithBooksCreatePost)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [HadithBookRequest](#HadithBookRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
delete /api/Admin/HadithBooks/Delete/{id}
```

(apiAdminHadithBooksDeleteIdDelete)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/HadithBooks/GetAll
```

(apiAdminHadithBooksGetAllGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/HadithBooks/GetById/{id}
```

(apiAdminHadithBooksGetByIdIdGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/HadithBooks/{id}/chapters
```

(apiAdminHadithBooksIdChaptersGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/HadithBooks/{id}/hadiths
```

(apiAdminHadithBooksIdHadithsGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/HadithBooks/{id}/random
```

(apiAdminHadithBooksIdRandomGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/HadithBooks/{id}/stats
```

(apiAdminHadithBooksIdStatsGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/HadithBooks/Search
```

(apiAdminHadithBooksSearchGet)

### Query parameters

query (optional)

Query Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
patch /api/Admin/HadithBooks/ToggleStatus/{id}
```

(apiAdminHadithBooksToggleStatusIdPatch)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
put /api/Admin/HadithBooks/Update/{id}
```

(apiAdminHadithBooksUpdateIdPut)

### Path parameters

id (required)

Path Parameter — format: int32

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [HadithBookRequest](#HadithBookRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/HadithBooks/GetAll
```

(apiStudentHadithBooksGetAllGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/HadithBooks/GetById/{id}
```

(apiStudentHadithBooksGetByIdIdGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/HadithBooks/{id}/chapters
```

(apiStudentHadithBooksIdChaptersGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/HadithBooks/{id}/hadiths
```

(apiStudentHadithBooksIdHadithsGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/HadithBooks/{id}/random
```

(apiStudentHadithBooksIdRandomGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/HadithBooks/{id}/stats
```

(apiStudentHadithBooksIdStatsGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/HadithBooks/Search
```

(apiStudentHadithBooksSearchGet)

### Query parameters

query (optional)

Query Parameter —

### Responses

#### 200

OK[](#)

- - -

# HadithChapters

[Up](#__Methods)

```
get /api/Admin/HadithChapters/book/{bookId}
```

(apiAdminHadithChaptersBookBookIdGet)

### Path parameters

bookId (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
post /api/Admin/HadithChapters/Create
```

(apiAdminHadithChaptersCreatePost)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [HadithChapterRequest](#HadithChapterRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
delete /api/Admin/HadithChapters/Delete/{id}
```

(apiAdminHadithChaptersDeleteIdDelete)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/HadithChapters/GetAll
```

(apiAdminHadithChaptersGetAllGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/HadithChapters/GetById/{id}
```

(apiAdminHadithChaptersGetByIdIdGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/HadithChapters/{id}/hadiths
```

(apiAdminHadithChaptersIdHadithsGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/HadithChapters/{id}/random
```

(apiAdminHadithChaptersIdRandomGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/HadithChapters/{id}/stats
```

(apiAdminHadithChaptersIdStatsGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/HadithChapters/Search
```

(apiAdminHadithChaptersSearchGet)

### Query parameters

query (optional)

Query Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
patch /api/Admin/HadithChapters/ToggleStatus/{id}
```

(apiAdminHadithChaptersToggleStatusIdPatch)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
put /api/Admin/HadithChapters/Update/{id}
```

(apiAdminHadithChaptersUpdateIdPut)

### Path parameters

id (required)

Path Parameter — format: int32

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [HadithChapterRequest](#HadithChapterRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/HadithChapters/book/{bookId}
```

(apiStudentHadithChaptersBookBookIdGet)

### Path parameters

bookId (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/HadithChapters/GetAll
```

(apiStudentHadithChaptersGetAllGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/HadithChapters/GetById/{id}
```

(apiStudentHadithChaptersGetByIdIdGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/HadithChapters/{id}/hadiths
```

(apiStudentHadithChaptersIdHadithsGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/HadithChapters/{id}/random
```

(apiStudentHadithChaptersIdRandomGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/HadithChapters/{id}/stats
```

(apiStudentHadithChaptersIdStatsGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/HadithChapters/Search
```

(apiStudentHadithChaptersSearchGet)

### Query parameters

query (optional)

Query Parameter —

### Responses

#### 200

OK[](#)

- - -

# Hadiths

[Up](#__Methods)

```
get /api/Admin/Hadiths/book/{bookId}
```

(apiAdminHadithsBookBookIdGet)

### Path parameters

bookId (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/Hadiths/chapter/{chapterId}
```

(apiAdminHadithsChapterChapterIdGet)

### Path parameters

chapterId (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
post /api/Admin/Hadiths/Create
```

(apiAdminHadithsCreatePost)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [HadithRequest](#HadithRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
delete /api/Admin/Hadiths/Delete/{id}
```

(apiAdminHadithsDeleteIdDelete)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/Hadiths/englishNarrator/{name}
```

(apiAdminHadithsEnglishNarratorNameGet)

### Path parameters

name (required)

Path Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/Hadiths/GetAll
```

(apiAdminHadithsGetAllGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/Hadiths/GetById/{id}
```

(apiAdminHadithsGetByIdIdGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/Hadiths/random
```

(apiAdminHadithsRandomGet)

### Query parameters

bookId (optional)

Query Parameter — format: int32

chapterId (optional)

Query Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/Hadiths/Search
```

(apiAdminHadithsSearchGet)

### Query parameters

query (optional)

Query Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/Hadiths/stats
```

(apiAdminHadithsStatsGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
patch /api/Admin/Hadiths/ToggleStatus/{id}
```

(apiAdminHadithsToggleStatusIdPatch)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
put /api/Admin/Hadiths/Update/{id}
```

(apiAdminHadithsUpdateIdPut)

### Path parameters

id (required)

Path Parameter — format: int32

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [HadithRequest](#HadithRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Hadiths/book/{bookId}
```

(apiStudentHadithsBookBookIdGet)

### Path parameters

bookId (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Hadiths/chapter/{chapterId}
```

(apiStudentHadithsChapterChapterIdGet)

### Path parameters

chapterId (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Hadiths/englishNarrator/{name}
```

(apiStudentHadithsEnglishNarratorNameGet)

### Path parameters

name (required)

Path Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Hadiths/GetAll
```

(apiStudentHadithsGetAllGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Hadiths/GetById/{id}
```

(apiStudentHadithsGetByIdIdGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Hadiths/random
```

(apiStudentHadithsRandomGet)

### Query parameters

bookId (optional)

Query Parameter — format: int32

chapterId (optional)

Query Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Hadiths/Search
```

(apiStudentHadithsSearchGet)

### Query parameters

query (optional)

Query Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Hadiths/stats
```

(apiStudentHadithsStatsGet)

### Responses

#### 200

OK[](#)

- - -

# Lesson

[Up](#__Methods)

```
post /api/Admin/Lesson/Create
```

(apiAdminLessonCreatePost)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/x-www-form-urlencoded`

### Form parameters

Title (required)

Form Parameter —

CourseId (required)

Form Parameter — format: int32

ContentText (required)

Form Parameter —

Files (required)

Form Parameter —

FileTypes (required)

Form Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
delete /api/Admin/Lesson/Delete/{id}
```

(apiAdminLessonDeleteIdDelete)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/Lesson/GetAll
```

(apiAdminLessonGetAllGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/Lesson/GetByCourseId/{courseId}
```

(apiAdminLessonGetByCourseIdCourseIdGet)

### Path parameters

courseId (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/Lesson/GetById/{id}
```

(apiAdminLessonGetByIdIdGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
patch /api/Admin/Lesson/ToggleStatus/{id}
```

(apiAdminLessonToggleStatusIdPatch)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
put /api/Admin/Lesson/Update/{id}
```

(apiAdminLessonUpdateIdPut)

### Path parameters

id (required)

Path Parameter — format: int32

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/x-www-form-urlencoded`

### Form parameters

Title (required)

Form Parameter —

CourseId (required)

Form Parameter — format: int32

ContentText (required)

Form Parameter —

Files (required)

Form Parameter —

FileTypes (required)

Form Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Lesson/GetAll
```

(apiStudentLessonGetAllGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Lesson/GetByCourseId/{courseId}
```

(apiStudentLessonGetByCourseIdCourseIdGet)

### Path parameters

courseId (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Lesson/GetById/{id}
```

(apiStudentLessonGetByIdIdGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

# Quiz

[Up](#__Methods)

```
post /api/Admin/Quiz/Create
```

(apiAdminQuizCreatePost)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [QuizRequest](#QuizRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
delete /api/Admin/Quiz/Delete/{id}
```

(apiAdminQuizDeleteIdDelete)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/Quiz/GetAll
```

(apiAdminQuizGetAllGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/Quiz/GetById/{id}
```

(apiAdminQuizGetByIdIdGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
patch /api/Admin/Quiz/ToggleStatus/{id}
```

(apiAdminQuizToggleStatusIdPatch)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
put /api/Admin/Quiz/Update/{id}
```

(apiAdminQuizUpdateIdPut)

### Path parameters

id (required)

Path Parameter — format: int32

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [QuizRequest](#QuizRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Quiz/GetAll
```

(apiStudentQuizGetAllGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Quiz/GetById/{id}
```

(apiStudentQuizGetByIdIdGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

# Quran

[Up](#__Methods)

```
get /api/Admin/Quran/SearchGeneric
```

(apiAdminQuranSearchGenericGet)

### Query parameters

query (optional)

Query Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/Quran/search
```

(apiAdminQuranSearchGet)

### Query parameters

q (optional)

Query Parameter —

limit (optional)

Query Parameter — default: 50 format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/Quran/surahs
```

(apiAdminQuranSurahsGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/Quran/surahs/{number}
```

(apiAdminQuranSurahsNumberGet)

### Path parameters

number (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/Quran/surahs/{surahNumber}/ayahs/{ayahNumber}
```

(apiAdminQuranSurahsSurahNumberAyahsAyahNumberGet)

### Path parameters

surahNumber (required)

Path Parameter — format: int32

ayahNumber (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Quran/SearchGeneric
```

(apiStudentQuranSearchGenericGet)

### Query parameters

query (optional)

Query Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Quran/search
```

(apiStudentQuranSearchGet)

### Query parameters

q (optional)

Query Parameter —

limit (optional)

Query Parameter — default: 50 format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Quran/surahs
```

(apiStudentQuranSurahsGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Quran/surahs/{number}
```

(apiStudentQuranSurahsNumberGet)

### Path parameters

number (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/Quran/surahs/{surahNumber}/ayahs/{ayahNumber}
```

(apiStudentQuranSurahsSurahNumberAyahsAyahNumberGet)

### Path parameters

surahNumber (required)

Path Parameter — format: int32

ayahNumber (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

# ThikrCategory

[Up](#__Methods)

```
post /api/Admin/ThikrCategory/Create
```

(apiAdminThikrCategoryCreatePost)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [ThikrCategoryRequest](#ThikrCategoryRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
delete /api/Admin/ThikrCategory/Delete/{id}
```

(apiAdminThikrCategoryDeleteIdDelete)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/ThikrCategory/GetAll
```

(apiAdminThikrCategoryGetAllGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/ThikrCategory/GetAudioUrls
```

(apiAdminThikrCategoryGetAudioUrlsGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/ThikrCategory/GetById/{id}
```

(apiAdminThikrCategoryGetByIdIdGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/ThikrCategory/Search
```

(apiAdminThikrCategorySearchGet)

### Query parameters

query (optional)

Query Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
patch /api/Admin/ThikrCategory/ToggleStatus/{id}
```

(apiAdminThikrCategoryToggleStatusIdPatch)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
put /api/Admin/ThikrCategory/Update/{id}
```

(apiAdminThikrCategoryUpdateIdPut)

### Path parameters

id (required)

Path Parameter — format: int32

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [ThikrCategoryRequest](#ThikrCategoryRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/ThikrCategory/GetAll
```

(apiStudentThikrCategoryGetAllGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/ThikrCategory/GetById/{id}
```

(apiStudentThikrCategoryGetByIdIdGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/ThikrCategory/Search
```

(apiStudentThikrCategorySearchGet)

### Query parameters

query (optional)

Query Parameter —

### Responses

#### 200

OK[](#)

- - -

# ThikrItem

[Up](#__Methods)

```
post /api/Admin/ThikrItem/Create
```

(apiAdminThikrItemCreatePost)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [ThikrItemRequest](#ThikrItemRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
delete /api/Admin/ThikrItem/Delete/{id}
```

(apiAdminThikrItemDeleteIdDelete)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/ThikrItem/GetAll
```

(apiAdminThikrItemGetAllGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/ThikrItem/GetByCategoryId/{categoryId}
```

(apiAdminThikrItemGetByCategoryIdCategoryIdGet)

### Path parameters

categoryId (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/ThikrItem/GetByCount
```

(apiAdminThikrItemGetByCountGet)

### Query parameters

minCount (optional)

Query Parameter — format: int32

maxCount (optional)

Query Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/ThikrItem/GetById/{id}
```

(apiAdminThikrItemGetByIdIdGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/ThikrItem/Search
```

(apiAdminThikrItemSearchGet)

### Query parameters

query (optional)

Query Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
patch /api/Admin/ThikrItem/ToggleStatus/{id}
```

(apiAdminThikrItemToggleStatusIdPatch)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
put /api/Admin/ThikrItem/Update/{id}
```

(apiAdminThikrItemUpdateIdPut)

### Path parameters

id (required)

Path Parameter — format: int32

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [ThikrItemRequest](#ThikrItemRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/ThikrItem/GetAll
```

(apiStudentThikrItemGetAllGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/ThikrItem/GetByCategoryId/{categoryId}
```

(apiStudentThikrItemGetByCategoryIdCategoryIdGet)

### Path parameters

categoryId (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/ThikrItem/GetByCount
```

(apiStudentThikrItemGetByCountGet)

### Query parameters

minCount (optional)

Query Parameter — format: int32

maxCount (optional)

Query Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/ThikrItem/GetById/{id}
```

(apiStudentThikrItemGetByIdIdGet)

### Path parameters

id (required)

Path Parameter — format: int32

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/ThikrItem/Search
```

(apiStudentThikrItemSearchGet)

### Query parameters

query (optional)

Query Parameter —

### Responses

#### 200

OK[](#)

- - -

# User

[Up](#__Methods)

```
patch /api/Admin/User/BlockUser/{userId}
```

(apiAdminUserBlockUserUserIdPatch)

### Path parameters

userId (required)

Path Parameter —

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [integer](#integer) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
put /api/Admin/User/ChangeEmail
```

(apiAdminUserChangeEmailPut)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [ChangeEmailRequest](#ChangeEmailRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
put /api/Admin/User/ChangePassword
```

(apiAdminUserChangePasswordPut)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [ChangePasswordRequest](#ChangePasswordRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
patch /api/Admin/User/ChangeRole/{userId}
```

(apiAdminUserChangeRoleUserIdPatch)

### Path parameters

userId (required)

Path Parameter —

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [ChangeRoleRequest](#ChangeRoleRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/User/ConfirmNewEmail
```

(apiAdminUserConfirmNewEmailGet)

### Query parameters

userId (optional)

Query Parameter —

token (optional)

Query Parameter —

newEmail (optional)

Query Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/User/GetAllUsers
```

(apiAdminUserGetAllUsersGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/User/GetMyProfile
```

(apiAdminUserGetMyProfileGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/User/GetUserById/{id}
```

(apiAdminUserGetUserByIdIdGet)

### Path parameters

id (required)

Path Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
patch /api/Admin/User/IsBlockedUser/{userId}
```

(apiAdminUserIsBlockedUserUserIdPatch)

### Path parameters

userId (required)

Path Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
patch /api/Admin/User/UnBlockUser/{userId}
```

(apiAdminUserUnBlockUserUserIdPatch)

### Path parameters

userId (required)

Path Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
put /api/Admin/User/UpdateMyProfile
```

(apiAdminUserUpdateMyProfilePut)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [UpdateProfileRequest](#UpdateProfileRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
put /api/Student/User/ChangeEmail
```

(apiStudentUserChangeEmailPut)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [ChangeEmailRequest](#ChangeEmailRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
put /api/Student/User/ChangePassword
```

(apiStudentUserChangePasswordPut)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [ChangePasswordRequest](#ChangePasswordRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/User/ConfirmNewEmail
```

(apiStudentUserConfirmNewEmailGet)

### Query parameters

userId (optional)

Query Parameter —

token (optional)

Query Parameter —

newEmail (optional)

Query Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/User/GetMyProfile
```

(apiStudentUserGetMyProfileGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
put /api/Student/User/UpdateMyProfile
```

(apiStudentUserUpdateMyProfilePut)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [UpdateProfileRequest](#UpdateProfileRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

# UserProgress

[Up](#__Methods)

```
post /api/Admin/UserProgress/add
```

(apiAdminUserProgressAddPost)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [ProgressCreateRequest](#ProgressCreateRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Admin/UserProgress/me
```

(apiAdminUserProgressMeGet)

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
post /api/Student/UserProgress/add
```

(apiStudentUserProgressAddPost)

### Consumes

This API call consumes the following media types via the Content-Type request header:

*   `application/json`
*   `text/json`
*   `application/*+json`

### Request body

body [ProgressCreateRequest](#ProgressCreateRequest) (required)

Body Parameter —

### Responses

#### 200

OK[](#)

- - -

[Up](#__Methods)

```
get /api/Student/UserProgress/me
```

(apiStudentUserProgressMeGet)

### Responses

#### 200

OK[](#)

- - -

## Models

\[ Jump to [Methods](#__Methods) \]

### Table of Contents

1.  [`Category_Create_body`](#Category_Create_body)
2.  [`ChangeEmailRequest`](#ChangeEmailRequest)
3.  [`ChangePasswordRequest`](#ChangePasswordRequest)
4.  [`ChangeRoleRequest`](#ChangeRoleRequest)
5.  [`Course_Create_body`](#Course_Create_body)
6.  [`FilesTypes`](#FilesTypes)
7.  [`ForgotPasswordRequest`](#ForgotPasswordRequest)
8.  [`HadithBookRequest`](#HadithBookRequest)
9.  [`HadithChapterRequest`](#HadithChapterRequest)
10.  [`HadithRequest`](#HadithRequest)
11.  [`IFormFile`](#IFormFile)
12.  [`Lesson_Create_body`](#Lesson_Create_body)
13.  [`LoginRequest`](#LoginRequest)
14.  [`ProgressCreateRequest`](#ProgressCreateRequest)
15.  [`ProgressType`](#ProgressType)
16.  [`QuestionRequest`](#QuestionRequest)
17.  [`QuizRequest`](#QuizRequest)
18.  [`RefreshTokenRequest`](#RefreshTokenRequest)
19.  [`RegisterRequest`](#RegisterRequest)
20.  [`ResetPasswordRequest`](#ResetPasswordRequest)
21.  [`ThikrCategoryRequest`](#ThikrCategoryRequest)
22.  [`ThikrItemRequest`](#ThikrItemRequest)
23.  [`UpdateProfileRequest`](#UpdateProfileRequest)
24.  [`Update_id_body`](#Update_id_body)
25.  [`Update_id_body_1`](#Update_id_body_1)
26.  [`Update_id_body_2`](#Update_id_body_2)
27.  [`UserDto`](#UserDto)

### `Category_Create_body` [Up](#__Models)

Name (optional)

[String](#string)

MainImage (optional)

[IFormFile](#IFormFile)

### `ChangeEmailRequest` [Up](#__Models)

newEmail (optional)

[String](#string)

### `ChangePasswordRequest` [Up](#__Models)

currentPassword (optional)

[String](#string)

newPassword (optional)

[String](#string)

### `ChangeRoleRequest` [Up](#__Models)

roleName (optional)

[String](#string)

### `Course_Create_body` [Up](#__Models)

Title (optional)

[String](#string)

Description (optional)

[String](#string)

CategoryId (optional)

[Integer](#integer) format: int32

LessonIds (optional)

[array\[Integer\]](#integer) format: int32

MainImage (optional)

[IFormFile](#IFormFile)

### `FilesTypes` [Up](#__Models)

### `ForgotPasswordRequest` [Up](#__Models)

email (optional)

[String](#string)

### `HadithBookRequest` [Up](#__Models)

arabicTitle (optional)

[String](#string)

arabicAuthor (optional)

[String](#string)

arabicIntroduction (optional)

[String](#string)

englishTitle (optional)

[String](#string)

englishAuthor (optional)

[String](#string)

englishIntroduction (optional)

[String](#string)

### `HadithChapterRequest` [Up](#__Models)

arabicTitle (optional)

[String](#string)

englishTitle (optional)

[String](#string)

hadithBookId (optional)

[Integer](#integer) format: int32

### `HadithRequest` [Up](#__Models)

idInBook (optional)

[Integer](#integer) format: int32

arabicText (optional)

[String](#string)

normalizedText (optional)

[String](#string)

englishNarrator (optional)

[String](#string)

englishText (optional)

[String](#string)

hadithChapterId (optional)

[Integer](#integer) format: int32

hadithBookId (optional)

[Integer](#integer) format: int32

### `IFormFile` [Up](#__Models)

### `Lesson_Create_body` [Up](#__Models)

Title (optional)

[String](#string)

CourseId (optional)

[Integer](#integer) format: int32

ContentText (optional)

[String](#string)

Files (optional)

[array\[IFormFile\]](#IFormFile)

FileTypes (optional)

[array\[FilesTypes\]](#FilesTypes)

### `LoginRequest` [Up](#__Models)

email (optional)

[String](#string)

password (optional)

[String](#string)

### `ProgressCreateRequest` [Up](#__Models)

type (optional)

[ProgressType](#ProgressType)

relatedItemId (optional)

[Integer](#integer) format: int32

count (optional)

[Integer](#integer) format: int32

### `ProgressType` [Up](#__Models)

### `QuestionRequest` [Up](#__Models)

text (optional)

[String](#string)

correctAnswer (optional)

[String](#string)

options (optional)

[array\[String\]](#string)

### `QuizRequest` [Up](#__Models)

title (optional)

[String](#string)

lessonId (optional)

[Integer](#integer) format: int32

questions (optional)

[array\[QuestionRequest\]](#QuestionRequest)

### `RefreshTokenRequest` [Up](#__Models)

refreshToken (optional)

[String](#string)

### `RegisterRequest` [Up](#__Models)

fullName (optional)

[String](#string)

userName (optional)

[String](#string)

email (optional)

[String](#string)

password (optional)

[String](#string)

phoneNumber (optional)

[String](#string)

### `ResetPasswordRequest` [Up](#__Models)

newPassword (optional)

[String](#string)

email (optional)

[String](#string)

code (optional)

[String](#string)

### `ThikrCategoryRequest` [Up](#__Models)

title (optional)

[String](#string)

normalizedText (optional)

[String](#string)

audioUrl (optional)

[String](#string)

### `ThikrItemRequest` [Up](#__Models)

text (optional)

[String](#string)

normalizedText (optional)

[String](#string)

count (optional)

[Integer](#integer) format: int32

description (optional)

[String](#string)

reference (optional)

[String](#string)

thikrCategoryId (optional)

[Integer](#integer) format: int32

### `UpdateProfileRequest` [Up](#__Models)

fullName (optional)

[String](#string)

userName (optional)

[String](#string)

phoneNumber (optional)

[String](#string)

city (optional)

[String](#string)

street (optional)

[String](#string)

### `Update_id_body` [Up](#__Models)

Title (optional)

[String](#string)

Description (optional)

[String](#string)

CategoryId (optional)

[Integer](#integer) format: int32

LessonIds (optional)

[array\[Integer\]](#integer) format: int32

MainImage (optional)

[IFormFile](#IFormFile)

### `Update_id_body_1` [Up](#__Models)

Title (optional)

[String](#string)

CourseId (optional)

[Integer](#integer) format: int32

ContentText (optional)

[String](#string)

Files (optional)

[array\[IFormFile\]](#IFormFile)

FileTypes (optional)

[array\[FilesTypes\]](#FilesTypes)

### `Update_id_body_2` [Up](#__Models)

Name (optional)

[String](#string)

MainImage (optional)

[IFormFile](#IFormFile)

### `UserDto` [Up](#__Models)

accessToken (optional)

[String](#string)

refreshToken (optional)

[String](#string)