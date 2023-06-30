import "./styles.css";
import P from "prop-types";

export const PostCard = ({ post }) => (
  <div className="post">
    <img src={post.cover} alt={post.title} />
    <div className="post-content">
      <h2>{post.title}</h2>
      <p>{post.body}</p>
    </div>
  </div>
);

PostCard.defaultProps = {
  posts: [],
};

PostCard.propTypes = {
  post: P.object.isRequired,
};
