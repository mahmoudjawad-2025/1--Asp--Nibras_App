openapi: 3.0.1
info
  title: PL | v1
  version: 1.0.0
servers

**url**: https://localhost:7050


**url**: http://localhost:5160



paths
/api/Student/Course/GetAll
## get
  ## tags
    1. Course
  ## responses
    ## 200
      **description**: OK

/api/Student/Course/GetById/{id}
## get
  ## tags
    1. Course
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/Lesson/GetAll
## get
  ## tags
    1. Lesson
  ## responses
    ## 200
      **description**: OK

/api/Student/Lesson/GetById/{id}
## get
  ## tags
    1. Lesson
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/Lesson/GetByCourseId/{courseId}
## get
  ## tags
    1. Lesson
  ## parameters
    1.           **name**: courseId
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/Quiz/GetAll
## get
  ## tags
    1. Quiz
  ## responses
    ## 200
      **description**: OK

/api/Student/Quiz/GetById/{id}
## get
  ## tags
    1. Quiz
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/Quran/surahs
## get
  ## tags
    1. Quran
  ## responses
    ## 200
      **description**: OK

/api/Student/Quran/surahs/{number}
## get
  ## tags
    1. Quran
  ## parameters
    1.           **name**: number
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/Quran/surahs/{surahNumber}/ayahs/{ayahNumber}
## get
  ## tags
    1. Quran
  ## parameters
    1.           **name**: surahNumber
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
    2.           **name**: ayahNumber
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/Quran/search
## get
  ## tags
    1. Quran
  ## parameters
    1.           **name**: q
      **in**: query
      ## schema
        **type**: string
    2.           **name**: limit
      **in**: query
      ## schema
        **type**: integer
        **format**: int32
        **default**: 50
  ## responses
    ## 200
      **description**: OK

/api/Student/Quran/SearchGeneric
## get
  ## tags
    1. Quran
  ## parameters
    1.           **name**: query
      **in**: query
      ## schema
        **type**: string
  ## responses
    ## 200
      **description**: OK

/api/Student/User/GetMyProfile
## get
  ## tags
    1. User
  ## responses
    ## 200
      **description**: OK

/api/Student/User/UpdateMyProfile
## put
  ## tags
    1. User
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/UpdateProfileRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/UpdateProfileRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/UpdateProfileRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Student/User/ChangePassword
## put
  ## tags
    1. User
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/ChangePasswordRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/ChangePasswordRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/ChangePasswordRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Student/User/ChangeEmail
## put
  ## tags
    1. User
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/ChangeEmailRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/ChangeEmailRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/ChangeEmailRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Student/User/ConfirmNewEmail
## get
  ## tags
    1. User
  ## parameters
    1.           **name**: userId
      **in**: query
      ## schema
        **type**: string
    2.           **name**: token
      **in**: query
      ## schema
        **type**: string
    3.           **name**: newEmail
      **in**: query
      ## schema
        **type**: string
  ## responses
    ## 200
      **description**: OK

/api/Student/UserProgress/add
## post
  ## tags
    1. UserProgress
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/ProgressCreateRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/ProgressCreateRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/ProgressCreateRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Student/UserProgress/me
## get
  ## tags
    1. UserProgress
  ## responses
    ## 200
      **description**: OK

/api/Student/ThikrCategory/GetAll
## get
  ## tags
    1. ThikrCategory
  ## responses
    ## 200
      **description**: OK

/api/Student/ThikrCategory/GetById/{id}
## get
  ## tags
    1. ThikrCategory
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/ThikrCategory/Search
## get
  ## tags
    1. ThikrCategory
  ## parameters
    1.           **name**: query
      **in**: query
      ## schema
        **type**: string
  ## responses
    ## 200
      **description**: OK

/api/Student/ThikrItem/GetAll
## get
  ## tags
    1. ThikrItem
  ## responses
    ## 200
      **description**: OK

/api/Student/ThikrItem/GetById/{id}
## get
  ## tags
    1. ThikrItem
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/ThikrItem/GetByCategoryId/{categoryId}
## get
  ## tags
    1. ThikrItem
  ## parameters
    1.           **name**: categoryId
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/ThikrItem/Search
## get
  ## tags
    1. ThikrItem
  ## parameters
    1.           **name**: query
      **in**: query
      ## schema
        **type**: string
  ## responses
    ## 200
      **description**: OK

/api/Student/ThikrItem/GetByCount
## get
  ## tags
    1. ThikrItem
  ## parameters
    1.           **name**: minCount
      **in**: query
      ## schema
        **type**: integer
        **format**: int32
    2.           **name**: maxCount
      **in**: query
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/HadithBooks/GetAll
## get
  ## tags
    1. HadithBooks
  ## responses
    ## 200
      **description**: OK

/api/Student/HadithBooks/GetById/{id}
## get
  ## tags
    1. HadithBooks
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/HadithBooks/Search
## get
  ## tags
    1. HadithBooks
  ## parameters
    1.           **name**: query
      **in**: query
      ## schema
        **type**: string
  ## responses
    ## 200
      **description**: OK

/api/Student/HadithBooks/{id}/chapters
## get
  ## tags
    1. HadithBooks
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/HadithBooks/{id}/hadiths
## get
  ## tags
    1. HadithBooks
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/HadithBooks/{id}/random
## get
  ## tags
    1. HadithBooks
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/HadithBooks/{id}/stats
## get
  ## tags
    1. HadithBooks
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/HadithChapters/GetAll
## get
  ## tags
    1. HadithChapters
  ## responses
    ## 200
      **description**: OK

/api/Student/HadithChapters/GetById/{id}
## get
  ## tags
    1. HadithChapters
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/HadithChapters/book/{bookId}
## get
  ## tags
    1. HadithChapters
  ## parameters
    1.           **name**: bookId
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/HadithChapters/Search
## get
  ## tags
    1. HadithChapters
  ## parameters
    1.           **name**: query
      **in**: query
      ## schema
        **type**: string
  ## responses
    ## 200
      **description**: OK

/api/Student/HadithChapters/{id}/hadiths
## get
  ## tags
    1. HadithChapters
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/HadithChapters/{id}/random
## get
  ## tags
    1. HadithChapters
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/HadithChapters/{id}/stats
## get
  ## tags
    1. HadithChapters
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/Hadiths/GetAll
## get
  ## tags
    1. Hadiths
  ## responses
    ## 200
      **description**: OK

/api/Student/Hadiths/GetById/{id}
## get
  ## tags
    1. Hadiths
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/Hadiths/chapter/{chapterId}
## get
  ## tags
    1. Hadiths
  ## parameters
    1.           **name**: chapterId
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/Hadiths/book/{bookId}
## get
  ## tags
    1. Hadiths
  ## parameters
    1.           **name**: bookId
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/Hadiths/Search
## get
  ## tags
    1. Hadiths
  ## parameters
    1.           **name**: query
      **in**: query
      ## schema
        **type**: string
  ## responses
    ## 200
      **description**: OK

/api/Student/Hadiths/englishNarrator/{name}
## get
  ## tags
    1. Hadiths
  ## parameters
    1.           **name**: name
      **in**: path
      **required**: true
      ## schema
        **type**: string
  ## responses
    ## 200
      **description**: OK

/api/Student/Hadiths/random
## get
  ## tags
    1. Hadiths
  ## parameters
    1.           **name**: bookId
      **in**: query
      ## schema
        **type**: integer
        **format**: int32
        **default**: null
    2.           **name**: chapterId
      **in**: query
      ## schema
        **type**: integer
        **format**: int32
        **default**: null
  ## responses
    ## 200
      **description**: OK

/api/Student/Hadiths/stats
## get
  ## tags
    1. Hadiths
  ## responses
    ## 200
      **description**: OK

/api/Admin/Course/Create
## post
  ## tags
    1. Course
  ## requestBody
    ## content
      ## application/x-www-form-urlencoded
        ## schema
          **type**: object
          ## properties
            ## Title
              **type**: string
            ## Description
              **type**: string
            ## CategoryId
              **type**: integer
              **format**: int32
            ## LessonIds
              **type**: array
              ## items
                **type**: integer
                **format**: int32
            ## MainImage
              **$ref**: #/components/schemas/IFormFile
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/Course/Update/{id}
## put
  ## tags
    1. Course
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## requestBody
    ## content
      ## application/x-www-form-urlencoded
        ## schema
          **type**: object
          ## properties
            ## Title
              **type**: string
            ## Description
              **type**: string
            ## CategoryId
              **type**: integer
              **format**: int32
            ## LessonIds
              **type**: array
              ## items
                **type**: integer
                **format**: int32
            ## MainImage
              **$ref**: #/components/schemas/IFormFile
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/Course/ToggleStatus/{id}
## patch
  ## tags
    1. Course
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/Course/Delete/{id}
## delete
  ## tags
    1. Course
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/Course/GetAll
## get
  ## tags
    1. Course
  ## responses
    ## 200
      **description**: OK

/api/Admin/Course/GetById/{id}
## get
  ## tags
    1. Course
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/Lesson/Create
## post
  ## tags
    1. Lesson
  ## requestBody
    ## content
      ## application/x-www-form-urlencoded
        ## schema
          **type**: object
          ## properties
            ## Title
              **type**: string
            ## CourseId
              **type**: integer
              **format**: int32
            ## ContentText
              **type**: string
            ## Files
              **type**: array
              ## items
                **$ref**: #/components/schemas/IFormFile
            ## FileTypes
              **type**: array
              ## items
                **$ref**: #/components/schemas/FilesTypes
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/Lesson/Update/{id}
## put
  ## tags
    1. Lesson
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## requestBody
    ## content
      ## application/x-www-form-urlencoded
        ## schema
          **type**: object
          ## properties
            ## Title
              **type**: string
            ## CourseId
              **type**: integer
              **format**: int32
            ## ContentText
              **type**: string
            ## Files
              **type**: array
              ## items
                **$ref**: #/components/schemas/IFormFile
            ## FileTypes
              **type**: array
              ## items
                **$ref**: #/components/schemas/FilesTypes
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/Lesson/Delete/{id}
## delete
  ## tags
    1. Lesson
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/Lesson/ToggleStatus/{id}
## patch
  ## tags
    1. Lesson
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/Lesson/GetAll
## get
  ## tags
    1. Lesson
  ## responses
    ## 200
      **description**: OK

/api/Admin/Lesson/GetById/{id}
## get
  ## tags
    1. Lesson
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/Lesson/GetByCourseId/{courseId}
## get
  ## tags
    1. Lesson
  ## parameters
    1.           **name**: courseId
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/Quiz/Create
## post
  ## tags
    1. Quiz
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/QuizRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/QuizRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/QuizRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/Quiz/Update/{id}
## put
  ## tags
    1. Quiz
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/QuizRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/QuizRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/QuizRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/Quiz/ToggleStatus/{id}
## patch
  ## tags
    1. Quiz
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/Quiz/Delete/{id}
## delete
  ## tags
    1. Quiz
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/Quiz/GetAll
## get
  ## tags
    1. Quiz
  ## responses
    ## 200
      **description**: OK

/api/Admin/Quiz/GetById/{id}
## get
  ## tags
    1. Quiz
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/Quran/surahs
## get
  ## tags
    1. Quran
  ## responses
    ## 200
      **description**: OK

/api/Admin/Quran/surahs/{number}
## get
  ## tags
    1. Quran
  ## parameters
    1.           **name**: number
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/Quran/surahs/{surahNumber}/ayahs/{ayahNumber}
## get
  ## tags
    1. Quran
  ## parameters
    1.           **name**: surahNumber
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
    2.           **name**: ayahNumber
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/Quran/search
## get
  ## tags
    1. Quran
  ## parameters
    1.           **name**: q
      **in**: query
      ## schema
        **type**: string
    2.           **name**: limit
      **in**: query
      ## schema
        **type**: integer
        **format**: int32
        **default**: 50
  ## responses
    ## 200
      **description**: OK

/api/Admin/Quran/SearchGeneric
## get
  ## tags
    1. Quran
  ## parameters
    1.           **name**: query
      **in**: query
      ## schema
        **type**: string
  ## responses
    ## 200
      **description**: OK

/api/Admin/User/GetAllUsers
## get
  ## tags
    1. User
  ## responses
    ## 200
      **description**: OK

/api/Admin/User/GetUserById/{id}
## get
  ## tags
    1. User
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: string
  ## responses
    ## 200
      **description**: OK

/api/Admin/User/BlockUser/{userId}
## patch
  ## tags
    1. User
  ## parameters
    1.           **name**: userId
      **in**: path
      **required**: true
      ## schema
        **type**: string
  ## requestBody
    ## content
      ## application/json
        ## schema
          **type**: integer
          **format**: int32
      ## text/json
        ## schema
          **type**: integer
          **format**: int32
      ## application/*+json
        ## schema
          **type**: integer
          **format**: int32
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/User/UnBlockUser/{userId}
## patch
  ## tags
    1. User
  ## parameters
    1.           **name**: userId
      **in**: path
      **required**: true
      ## schema
        **type**: string
  ## responses
    ## 200
      **description**: OK

/api/Admin/User/IsBlockedUser/{userId}
## patch
  ## tags
    1. User
  ## parameters
    1.           **name**: userId
      **in**: path
      **required**: true
      ## schema
        **type**: string
  ## responses
    ## 200
      **description**: OK

/api/Admin/User/ChangeRole/{userId}
## patch
  ## tags
    1. User
  ## parameters
    1.           **name**: userId
      **in**: path
      **required**: true
      ## schema
        **type**: string
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/ChangeRoleRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/ChangeRoleRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/ChangeRoleRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/User/GetMyProfile
## get
  ## tags
    1. User
  ## responses
    ## 200
      **description**: OK

/api/Admin/User/UpdateMyProfile
## put
  ## tags
    1. User
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/UpdateProfileRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/UpdateProfileRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/UpdateProfileRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/User/ChangePassword
## put
  ## tags
    1. User
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/ChangePasswordRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/ChangePasswordRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/ChangePasswordRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/User/ChangeEmail
## put
  ## tags
    1. User
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/ChangeEmailRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/ChangeEmailRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/ChangeEmailRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/User/ConfirmNewEmail
## get
  ## tags
    1. User
  ## parameters
    1.           **name**: userId
      **in**: query
      ## schema
        **type**: string
    2.           **name**: token
      **in**: query
      ## schema
        **type**: string
    3.           **name**: newEmail
      **in**: query
      ## schema
        **type**: string
  ## responses
    ## 200
      **description**: OK

/api/Admin/UserProgress/add
## post
  ## tags
    1. UserProgress
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/ProgressCreateRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/ProgressCreateRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/ProgressCreateRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/UserProgress/me
## get
  ## tags
    1. UserProgress
  ## responses
    ## 200
      **description**: OK

/api/Admin/ThikrCategory/GetAudioUrls
## get
  ## tags
    1. ThikrCategory
  ## responses
    ## 200
      **description**: OK

/api/Admin/ThikrCategory/GetAll
## get
  ## tags
    1. ThikrCategory
  ## responses
    ## 200
      **description**: OK

/api/Admin/ThikrCategory/GetById/{id}
## get
  ## tags
    1. ThikrCategory
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/ThikrCategory/Search
## get
  ## tags
    1. ThikrCategory
  ## parameters
    1.           **name**: query
      **in**: query
      ## schema
        **type**: string
  ## responses
    ## 200
      **description**: OK

/api/Admin/ThikrCategory/Create
## post
  ## tags
    1. ThikrCategory
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/ThikrCategoryRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/ThikrCategoryRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/ThikrCategoryRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/ThikrCategory/Update/{id}
## put
  ## tags
    1. ThikrCategory
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/ThikrCategoryRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/ThikrCategoryRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/ThikrCategoryRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/ThikrCategory/Delete/{id}
## delete
  ## tags
    1. ThikrCategory
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/ThikrCategory/ToggleStatus/{id}
## patch
  ## tags
    1. ThikrCategory
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/ThikrItem/GetAll
## get
  ## tags
    1. ThikrItem
  ## responses
    ## 200
      **description**: OK

/api/Admin/ThikrItem/GetById/{id}
## get
  ## tags
    1. ThikrItem
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/ThikrItem/GetByCategoryId/{categoryId}
## get
  ## tags
    1. ThikrItem
  ## parameters
    1.           **name**: categoryId
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/ThikrItem/Search
## get
  ## tags
    1. ThikrItem
  ## parameters
    1.           **name**: query
      **in**: query
      ## schema
        **type**: string
  ## responses
    ## 200
      **description**: OK

/api/Admin/ThikrItem/GetByCount
## get
  ## tags
    1. ThikrItem
  ## parameters
    1.           **name**: minCount
      **in**: query
      ## schema
        **type**: integer
        **format**: int32
    2.           **name**: maxCount
      **in**: query
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/ThikrItem/Create
## post
  ## tags
    1. ThikrItem
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/ThikrItemRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/ThikrItemRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/ThikrItemRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/ThikrItem/Update/{id}
## put
  ## tags
    1. ThikrItem
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/ThikrItemRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/ThikrItemRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/ThikrItemRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/ThikrItem/Delete/{id}
## delete
  ## tags
    1. ThikrItem
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/ThikrItem/ToggleStatus/{id}
## patch
  ## tags
    1. ThikrItem
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithBooks/GetAll
## get
  ## tags
    1. HadithBooks
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithBooks/GetById/{id}
## get
  ## tags
    1. HadithBooks
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithBooks/Search
## get
  ## tags
    1. HadithBooks
  ## parameters
    1.           **name**: query
      **in**: query
      ## schema
        **type**: string
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithBooks/{id}/chapters
## get
  ## tags
    1. HadithBooks
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithBooks/{id}/hadiths
## get
  ## tags
    1. HadithBooks
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithBooks/{id}/random
## get
  ## tags
    1. HadithBooks
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithBooks/{id}/stats
## get
  ## tags
    1. HadithBooks
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithBooks/Create
## post
  ## tags
    1. HadithBooks
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/HadithBookRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/HadithBookRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/HadithBookRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithBooks/Update/{id}
## put
  ## tags
    1. HadithBooks
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/HadithBookRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/HadithBookRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/HadithBookRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithBooks/Delete/{id}
## delete
  ## tags
    1. HadithBooks
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithBooks/ToggleStatus/{id}
## patch
  ## tags
    1. HadithBooks
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithChapters/GetAll
## get
  ## tags
    1. HadithChapters
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithChapters/GetById/{id}
## get
  ## tags
    1. HadithChapters
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithChapters/book/{bookId}
## get
  ## tags
    1. HadithChapters
  ## parameters
    1.           **name**: bookId
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithChapters/Search
## get
  ## tags
    1. HadithChapters
  ## parameters
    1.           **name**: query
      **in**: query
      ## schema
        **type**: string
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithChapters/{id}/hadiths
## get
  ## tags
    1. HadithChapters
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithChapters/{id}/random
## get
  ## tags
    1. HadithChapters
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithChapters/{id}/stats
## get
  ## tags
    1. HadithChapters
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithChapters/Create
## post
  ## tags
    1. HadithChapters
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/HadithChapterRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/HadithChapterRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/HadithChapterRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithChapters/Update/{id}
## put
  ## tags
    1. HadithChapters
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/HadithChapterRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/HadithChapterRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/HadithChapterRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithChapters/Delete/{id}
## delete
  ## tags
    1. HadithChapters
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/HadithChapters/ToggleStatus/{id}
## patch
  ## tags
    1. HadithChapters
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/Hadiths/GetAll
## get
  ## tags
    1. Hadiths
  ## responses
    ## 200
      **description**: OK

/api/Admin/Hadiths/GetById/{id}
## get
  ## tags
    1. Hadiths
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/Hadiths/chapter/{chapterId}
## get
  ## tags
    1. Hadiths
  ## parameters
    1.           **name**: chapterId
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/Hadiths/book/{bookId}
## get
  ## tags
    1. Hadiths
  ## parameters
    1.           **name**: bookId
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/Hadiths/Search
## get
  ## tags
    1. Hadiths
  ## parameters
    1.           **name**: query
      **in**: query
      ## schema
        **type**: string
  ## responses
    ## 200
      **description**: OK

/api/Admin/Hadiths/englishNarrator/{name}
## get
  ## tags
    1. Hadiths
  ## parameters
    1.           **name**: name
      **in**: path
      **required**: true
      ## schema
        **type**: string
  ## responses
    ## 200
      **description**: OK

/api/Admin/Hadiths/random
## get
  ## tags
    1. Hadiths
  ## parameters
    1.           **name**: bookId
      **in**: query
      ## schema
        **type**: integer
        **format**: int32
        **default**: null
    2.           **name**: chapterId
      **in**: query
      ## schema
        **type**: integer
        **format**: int32
        **default**: null
  ## responses
    ## 200
      **description**: OK

/api/Admin/Hadiths/stats
## get
  ## tags
    1. Hadiths
  ## responses
    ## 200
      **description**: OK

/api/Admin/Hadiths/Create
## post
  ## tags
    1. Hadiths
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/HadithRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/HadithRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/HadithRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/Hadiths/Update/{id}
## put
  ## tags
    1. Hadiths
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/HadithRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/HadithRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/HadithRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/Hadiths/Delete/{id}
## delete
  ## tags
    1. Hadiths
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/Hadiths/ToggleStatus/{id}
## patch
  ## tags
    1. Hadiths
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Student/Category/GetAll
## get
  ## tags
    1. Category
  ## responses
    ## 200
      **description**: OK

/api/Student/Category/GetById/{id}
## get
  ## tags
    1. Category
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Identity/Authentication/Refresh
## post
  ## tags
    1. Authentication
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/RefreshTokenRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/RefreshTokenRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/RefreshTokenRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK
      ## content
        ## text/plain
          ## schema
            **$ref**: #/components/schemas/UserDto
        ## application/json
          ## schema
            **$ref**: #/components/schemas/UserDto
        ## text/json
          ## schema
            **$ref**: #/components/schemas/UserDto

/api/Identity/Authentication/Register
## post
  ## tags
    1. Authentication
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/RegisterRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/RegisterRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/RegisterRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK
      ## content
        ## text/plain
          ## schema
            **$ref**: #/components/schemas/UserDto
        ## application/json
          ## schema
            **$ref**: #/components/schemas/UserDto
        ## text/json
          ## schema
            **$ref**: #/components/schemas/UserDto

/api/Identity/Authentication/Login
## post
  ## tags
    1. Authentication
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/LoginRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/LoginRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/LoginRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK
      ## content
        ## text/plain
          ## schema
            **$ref**: #/components/schemas/UserDto
        ## application/json
          ## schema
            **$ref**: #/components/schemas/UserDto
        ## text/json
          ## schema
            **$ref**: #/components/schemas/UserDto

/api/Identity/Authentication/Logout
## post
  ## tags
    1. Authentication
  ## responses
    ## 200
      **description**: OK

/api/Identity/Authentication/ConfirmEmail
## get
  ## tags
    1. Authentication
  ## parameters
    1.           **name**: token
      **in**: query
      ## schema
        **type**: string
    2.           **name**: userId
      **in**: query
      ## schema
        **type**: string
  ## responses
    ## 200
      **description**: OK
      ## content
        ## text/plain
          ## schema
            **type**: string
        ## application/json
          ## schema
            **type**: string
        ## text/json
          ## schema
            **type**: string

/api/Identity/Authentication/ForgotPassword
## post
  ## tags
    1. Authentication
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/ForgotPasswordRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/ForgotPasswordRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/ForgotPasswordRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK
      ## content
        ## text/plain
          ## schema
            **type**: string
        ## application/json
          ## schema
            **type**: string
        ## text/json
          ## schema
            **type**: string

/api/Identity/Authentication/ResetPassword
## post
  ## tags
    1. Authentication
  ## requestBody
    ## content
      ## application/json
        ## schema
          **$ref**: #/components/schemas/ResetPasswordRequest
      ## text/json
        ## schema
          **$ref**: #/components/schemas/ResetPasswordRequest
      ## application/*+json
        ## schema
          **$ref**: #/components/schemas/ResetPasswordRequest
    **required**: true
  ## responses
    ## 200
      **description**: OK
      ## content
        ## text/plain
          ## schema
            **type**: string
        ## application/json
          ## schema
            **type**: string
        ## text/json
          ## schema
            **type**: string

/api/Admin/Category/GetAll
## get
  ## tags
    1. Category
  ## responses
    ## 200
      **description**: OK

/api/Admin/Category/GetById/{id}
## get
  ## tags
    1. Category
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/Category/Create
## post
  ## tags
    1. Category
  ## requestBody
    ## content
      ## application/x-www-form-urlencoded
        ## schema
          **type**: object
          ## properties
            ## Name
              **type**: string
            ## MainImage
              **$ref**: #/components/schemas/IFormFile
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/Category/Update/{id}
## patch
  ## tags
    1. Category
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## requestBody
    ## content
      ## application/x-www-form-urlencoded
        ## schema
          **type**: object
          ## properties
            ## Name
              **type**: string
            ## MainImage
              **$ref**: #/components/schemas/IFormFile
    **required**: true
  ## responses
    ## 200
      **description**: OK

/api/Admin/Category/ToggleStatus/{id}
## patch
  ## tags
    1. Category
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

/api/Admin/Category/Delete/{id}
## delete
  ## tags
    1. Category
  ## parameters
    1.           **name**: id
      **in**: path
      **required**: true
      ## schema
        **type**: integer
        **format**: int32
  ## responses
    ## 200
      **description**: OK

components
schemas
## ChangeEmailRequest
  **type**: object
  ## properties
    ## newEmail
      **type**: string
## ChangePasswordRequest
  **type**: object
  ## properties
    ## currentPassword
      **type**: string
    ## newPassword
      **type**: string
## ChangeRoleRequest
  **type**: object
  ## properties
    ## roleName
      **type**: string
## FilesTypes
  **type**: integer
## ForgotPasswordRequest
  **type**: object
  ## properties
    ## email
      **type**: string
## HadithBookRequest
  **type**: object
  ## properties
    ## arabicTitle
      **type**: string
    ## arabicAuthor
      **type**: string
    ## arabicIntroduction
      **type**: string
    ## englishTitle
      **type**: string
    ## englishAuthor
      **type**: string
    ## englishIntroduction
      **type**: string
## HadithChapterRequest
  **type**: object
  ## properties
    ## arabicTitle
      **type**: string
    ## englishTitle
      **type**: string
    ## hadithBookId
      **type**: integer
      **format**: int32
## HadithRequest
  **type**: object
  ## properties
    ## idInBook
      **type**: integer
      **format**: int32
    ## arabicText
      **type**: string
    ## normalizedText
      **type**: string
    ## englishNarrator
      **type**: string
    ## englishText
      **type**: string
    ## hadithChapterId
      **type**: integer
      **format**: int32
    ## hadithBookId
      **type**: integer
      **format**: int32
## IFormFile
  **type**: string
  **format**: binary
## LoginRequest
  **type**: object
  ## properties
    ## email
      **type**: string
    ## password
      **type**: string
## ProgressCreateRequest
  **type**: object
  ## properties
    ## type
      **$ref**: #/components/schemas/ProgressType
    ## relatedItemId
      **type**: integer
      **format**: int32
      **nullable**: true
    ## count
      **type**: integer
      **format**: int32
## ProgressType
  ## enum
    1. Thikr
    2. Hadith
    3. Category
## QuestionRequest
  **type**: object
  ## properties
    ## text
      **type**: string
    ## correctAnswer
      **type**: string
    ## options
      **type**: array
      ## items
        **type**: string
## QuizRequest
  **type**: object
  ## properties
    ## title
      **type**: string
    ## lessonId
      **type**: integer
      **format**: int32
    ## questions
      **type**: array
      ## items
        **$ref**: #/components/schemas/QuestionRequest
## RefreshTokenRequest
  **type**: object
  ## properties
    ## refreshToken
      **type**: string
## RegisterRequest
  **type**: object
  ## properties
    ## fullName
      **type**: string
    ## userName
      **type**: string
    ## email
      **type**: string
    ## password
      **type**: string
    ## phoneNumber
      **type**: string
## ResetPasswordRequest
  **type**: object
  ## properties
    ## newPassword
      **type**: string
    ## email
      **type**: string
    ## code
      **type**: string
## ThikrCategoryRequest
  **type**: object
  ## properties
    ## title
      **type**: string
    ## normalizedText
      **type**: string
    ## audioUrl
      **type**: string
## ThikrItemRequest
  **type**: object
  ## properties
    ## text
      **type**: string
    ## normalizedText
      **type**: string
    ## count
      **type**: integer
      **format**: int32
    ## description
      **type**: string
    ## reference
      **type**: string
    ## thikrCategoryId
      **type**: integer
      **format**: int32
## UpdateProfileRequest
  **type**: object
  ## properties
    ## fullName
      **type**: string
    ## userName
      **type**: string
    ## phoneNumber
      **type**: string
    ## city
      **type**: string
    ## street
      **type**: string
## UserDto
  **type**: object
  ## properties
    ## accessToken
      **type**: string
    ## refreshToken
      **type**: string

tags

**name**: Course


**name**: Lesson


**name**: Quiz


**name**: Quran


**name**: User


**name**: UserProgress


**name**: ThikrCategory


**name**: ThikrItem


**name**: HadithBooks


**name**: HadithChapters


**name**: Hadiths


**name**: Category


**name**: Authentication



