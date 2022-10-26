﻿using SapinotesAPI.Data.Models;

namespace SapinotesAPI.Repositories
{
    public interface INoteRepository
    {
        public Task<Note> AddNewNote(Note note);
        public Task<IEnumerable<Note>> GetAllNotesOfUser(int userId);
        public Task<IEnumerable<Note>> GetAllNotesOfSubject(int subjectId);
        public Task<IEnumerable<Note>> GetAllNotesOfSubjectOrderedByRating(int subjectId);
        public Task<IEnumerable<Note>> GetAllNewNotesOfSubject(int subjectId);
        public Task DeleteNoteById(int noteId);
        public Task<Note> GetNoteById(int noteId);

        public Task UpdateRatingOfNote(int noteID,int ratingValue);


    }
}
