import './styles.css';

import { Component } from 'react';
import { loadPosts } from '../../utils/load-posts';
import { Posts } from '../../components/Posts';

class Home extends Component{

  state = {
    posts: [],
    allPosts: []
  }

  async componentDidMount(){
    await this.loadPosts(); 
  }

  loadPosts = async () => {
    const postsAndPhostos = await loadPosts();
    this.setState({
      posts:  postsAndPhostos.slice(0,5),
      allPosts:  postsAndPhostos 
    });
  }

  render() {
    const { posts } = this.state;

    return (
      <section className='container'>
        <Posts posts={posts}></Posts>
      </section>
    );
  }
}

export default Home;
