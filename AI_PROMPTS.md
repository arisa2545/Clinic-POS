1. error เมื่อรัน create 

Error: Invalid option(s):
-f net10.0
   'net10.0' is not a valid value for -f. The possible values are:
      net7.0   - Target net7.0
      net8.0   - Target net8.0
      net9.0   - Target net9.0

AI Answer: ให้ใช้ net9.0 ไปก่อนแล้วค่อยไปเปลี่ยนใน .csproj เนื่องจากในเครื่องไม่มี version 10 เพื่อความเร็ว

แต่สิ่งที่เลือกคอไป install version 10 เพราะเห็นว่ามันชัวร์มากกว่า
