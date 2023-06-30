import "./styles.css";
import P from "prop-types";

import { PostCard } from "../PostCard";

export const Posts = ({ posts = [] }) => (
  <div className="posts">
    {posts.map((post) => (
      <PostCard key={post.id} post={post}></PostCard>
    ))}
  </div>
);

Posts.defaultProps = {
  posts: [],
};

Posts.propTypes = {
  posts: P.array,
};
