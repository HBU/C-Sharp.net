using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace MySchool
{
    public partial class ScoreMsgFrm : Form
    {
        private List<StudentMsg> StudentList;
        private List<CourseMsg> CourseList;
        private List<ScoreMsg> ScoreList;
        private int current;
        private MyScloolDBContext db;
        public ScoreMsgFrm()
        {
            InitializeComponent();
            StudentList = new List<StudentMsg>();  //初始化实体对象集合
            CourseList = new List<CourseMsg>();
            ScoreList = new List<ScoreMsg>();
            current = 1;                  //默认的当前图书编号
            string sqlConn = @"data source=.\SQLExpress;
                        initial catalog=MySchool;
                        integrated security=true";
            db = new MyScloolDBContext(sqlConn);
        }

        private void showScore()   //显示当前学生成绩信息
        {
            if (current >= 1 && current <= ScoreList.Count)
            {
                txtCourseId.Text = ScoreList[current - 1].CourseId.ToString();
                txtStudentId.Text = ScoreList[current - 1].StudentNo.ToString();
                txtScore.Text = ScoreList[current - 1].Score.ToString();
            }
        }

        private void ScoreMsgFrm_Load(object sender, EventArgs e)
        {
            var queryScore =                  //定义LINQ查询
                from score in db.scores
                select score;
            foreach (var score in queryScore) //执行LINQ查询
            {
                ScoreList.Add(score);         //把LINQ返回的成绩对象添加到集合之中
            }
            showScore();                      //显示当前成绩
        }

        private void txtCourseId_TextChanged(object sender, EventArgs e)
        {
            var queryCourse =      //定义LINQ查询，获得指定的课程名称
                from course in db.courses
                where course.CourseId == int.Parse(txtCourseId.Text)
                select course;
            foreach (var course in queryCourse)  //执行LINQ查询
            {
                txtCourseName.Text = course.CourseName; //显示课程名称
            }
                
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {
            var queryStudent =     //定义LINQ查询，获得指定的学生姓名
                from student in db.students
                where student.StudentNo == int.Parse(txtStudentId.Text)
                select student;
            foreach (var student in queryStudent)   //执行LINQ查询
            {
                txtStudentName.Text = student.StudentName;//显示学生姓名
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (current == 1)
                MessageBox.Show("已经到第一条了","注意",MessageBoxButtons.OK);
            else
            {
                current--;
                showScore();
            };

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (current == ScoreList.Count)
                MessageBox.Show("已经到最后一条了","注意",MessageBoxButtons.OK);
            else
            {
                current++;
                showScore();
            };
        }
        //添加成绩
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // int id = ScoreList[ScoreList.Count - 1].BookID + 1;   //生成图书ID号
            ScoreMsg score = new ScoreMsg(int.Parse(txtCourseId.Text),
                int.Parse(txtStudentId.Text),
                int.Parse(txtScore.Text));   //创建ScoreMsg对象，封装用户输入
            db.scores.InsertOnSubmit(score);    //将ScoreMsg对象添加到Table对象
            try
            {
                db.SubmitChanges();      //将更新结果提交DBMS
                ScoreList.Add(score);      //在实体集合中添加新ScoreMsg对象
                current = ScoreList.Count;
                showScore();             //显示新添加的图书
                MessageBox.Show("已经到成功添加新记录", "注意", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "注意", MessageBoxButtons.OK);
            }

        }
        //修改成绩
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (current >= 1 && current <= ScoreList.Count)
            {
                var updateScores =          //定义LINQ查询
                    from score in db.scores
                    where (score.CourseId == ScoreList[current - 1].CourseId && 
                    score.StudentNo == ScoreList[current -1].StudentNo)
                    select score;
                foreach (ScoreMsg score in updateScores)  //执行LINQ查询
                {   //根据用户输入修改指定实体对象的相应属性
                    score.Score =int.Parse(txtScore.Text);
                }
                try
                {
                    db.SubmitChanges();   //将更新结果提交DBMS
                    MessageBox.Show("已经到成功更新记录", "注意", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "注意", MessageBoxButtons.OK);
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (current >= 1 && current <= ScoreList.Count)
            {
                var delScore =       //定义LINQ查询
                    from score in db.scores
                    where (score.CourseId == ScoreList[current - 1].CourseId &&
                        score.StudentNo == ScoreList[current - 1].StudentNo)
                    select score;
                foreach (ScoreMsg score in delScore)  //执行LINQ查询
                {
                    db.scores.DeleteOnSubmit(score); //删除Table对象中的指定对象
                }
                try
                {
                    db.SubmitChanges();          //将更新结果提交DBMS
                    ScoreList.RemoveAt(current - 1);  //删除实体集中指定的图书
                    if (current > 0) current--;
                    showScore();                  //更新窗体的输出
                    MessageBox.Show("已经到成功删除记录", "注意", MessageBoxButtons.OK); ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "注意", MessageBoxButtons.OK);
                }
            }

        }
    }
}
